using System;
using System.Data;
using System.Web.UI.WebControls;
using System.Web.UI;

using Discuz.Control;
using Discuz.Forum;
using Discuz.Common;
using Button = Discuz.Control.Button;
using DataGrid = Discuz.Control.DataGrid;
using TextBox = Discuz.Control.TextBox;
using Discuz.Config;
using Discuz.Data;


namespace Discuz.Web.Admin
{
    /// <summary>
    /// 勋章日志列表
    /// </summary>
    
#if NET1
    public class medalsloggird : AdminPage
#else
    public partial class medalsloggird : AdminPage
#endif
    {

#if NET1
        #region 控件声明
        protected Discuz.Control.Calendar postdatetimeStart;
        protected Discuz.Control.Calendar postdatetimeEnd;
        protected Discuz.Control.TextBox reason;
        protected Discuz.Control.TextBox Username;
        protected Discuz.Control.Button SearchLog;
        protected Discuz.Control.Hint Hint1;
        protected Discuz.Control.DataGrid DataGrid1;
        protected Discuz.Control.TextBox deleteNum;
        protected Discuz.Control.Calendar deleteFrom;
        protected Discuz.Control.Button DelRec;
        #endregion
#endif


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                postdatetimeStart.SelectedDate = DateTime.Now.AddDays(-30);
                postdatetimeEnd.SelectedDate = DateTime.Now;
                BindData();
            }
        }

        public void BindData()
        {
            #region 数据绑定

            DataGrid1.AllowCustomPaging = true;
            DataGrid1.VirtualItemCount = GetRecordCount();

            if (ViewState["condition"] == null)
            {
                DataGrid1.DataSource = AdminMedalLogs.LogList(DataGrid1.PageSize, DataGrid1.CurrentPageIndex + 1);
            }
            else
            {
                DataGrid1.DataSource = AdminMedalLogs.LogList(DataGrid1.PageSize, DataGrid1.CurrentPageIndex + 1, ViewState["condition"].ToString());
            }

            DataGrid1.DataBind();

            #endregion
        }
        private int GetRecordCount()
        {
            #region 得到日志记录数

            if (ViewState["condition"] == null)
            {
                return AdminMedalLogs.RecordCount();
            }
            else
            {
                return AdminMedalLogs.RecordCount(ViewState["condition"].ToString());
            }

            #endregion
        }

        private void DelRec_Click(object sender, EventArgs e)
        {
            #region 删除指定条件的日志信息

            if (this.CheckCookie())
            {
                string condition = "";
                //switch (Request.Form["deleteMode"])
                //{
                //    case "chkall":
                //        if (DNTRequest.GetString("id") != "")
                //            condition = " [id] IN(" + DNTRequest.GetString("id") + ")";
                //        break;
                //    case "deleteNum":
                //        if (deleteNum.Text != "" && Utils.IsNumeric(deleteNum.Text))
                //            condition = " [id] not in (select top " + deleteNum.Text + " [id] from [" + BaseConfigs.GetTablePrefix + "medalslog] order by [id] desc)";
                //        break;
                //    case "deleteFrom":
                //        if (deleteFrom.SelectedDate.ToString() != "")
                //            condition = " [postdatetime]<'" + deleteFrom.SelectedDate.ToString() + "'";
                //        break;
                //}
                condition = DatabaseProvider.GetInstance().DelMedalLogCondition(Request.Form["deleteMode"].ToString(), DNTRequest.GetString("id").ToString(), deleteNum.Text.ToString(), deleteFrom.SelectedDate.ToString());
                if (condition != "")
                {
                    AdminMedalLogs.DeleteLog(condition);
                    Response.Redirect("forum_medalsloggird.aspx");
                }
                else
                {
                    base.RegisterStartupScript( "", "<script>alert('您未选中任何选项或输入参数错误！');window.location.href='forum_medalsloggird.aspx';</script>");
                }
            }

            #endregion
        }

        private void SearchLog_Click(object sender, EventArgs e)
        {
            #region 按指定查询条件搜索日志信息

            if (this.CheckCookie())
            {
                string sqlstring = DatabaseProvider.GetInstance().SearchMedalLog(postdatetimeStart.SelectedDate, postdatetimeEnd.SelectedDate, Username.Text, reason.Text);

                ViewState["condition"] = sqlstring;
                DataGrid1.CurrentPageIndex = 0;
                BindData();
            }

            #endregion
        }

        public string Medals(string medalid)
        {
            #region 勋章图片链接

            if (medalid.Trim() == "") return "";

            DataTable dt = DatabaseProvider.GetInstance().MedalsTable(medalid);
            if (dt.Rows.Count > 0)
                return "<img src=../../images/medals/" + dt.Rows[0]["image"].ToString() + " height=25px> " + dt.Rows[0]["name"].ToString();
            else
                return "";

            #endregion
        }

        protected void DataGrid_PageIndexChanged(object source, DataGridPageChangedEventArgs e)
        {
            DataGrid1.CurrentPageIndex = e.NewPageIndex;
            BindData();
        }

        public void GoToPagerButton_Click(object sender, EventArgs e)
        {
            BindData();
        }

        private void DataGrid_ItemDataBound(object sender, DataGridItemEventArgs e)
        {
            if (e.Item.Cells[10].Text.ToString().Length > 8)
            {
                e.Item.Cells[10].Text = Utils.HtmlEncode(e.Item.Cells[10].Text.Substring(0, 8)) + "...";
            }
        }

        public string BoolStr(string closed)
        {
            if (closed == "1")
            {
                return "<div align=center><img src=../images/OK.gif /></div>";
            }
            else
            {
                return "<div align=center><img src=../images/Cancel.gif /></div>";
            }
        }

        #region Web Form Designer generated code

        protected override void OnInit(EventArgs e)
        {
            InitializeComponent();
            base.OnInit(e);
        }

        private void InitializeComponent()
        {
            this.SearchLog.Click += new EventHandler(this.SearchLog_Click);
            this.DelRec.Click += new EventHandler(this.DelRec_Click);
            this.DataGrid1.GoToPagerButton.Click += new EventHandler(GoToPagerButton_Click);
            this.DataGrid1.ItemDataBound += new DataGridItemEventHandler(this.DataGrid_ItemDataBound);
            this.Load += new EventHandler(this.Page_Load);

            DataGrid1.TableHeaderName = "勋章授予记录";
            DataGrid1.AllowSorting = false;
            DataGrid1.ColumnSpan = 8;
        }

        #endregion
    }
}
﻿using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class TrendCharts_7Xing_7X_ZH : TrendChartPageBase
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            GridViewBind();
            ColorBind();
            GridView1.Style["border-collapse"] = "";
        }
    }

    protected void GridViewBind()
    {
        DataTable dt = new DataTable();
        dt = BLL.X7_ZH_SeleteByNum(30);
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }

    protected void ColorBind()
    {
        for (int i = 0; i < GridView1.Rows.Count; i++)
        {
            for (int j = 3; j < 37; j++)
            {
                if (GridView1.Rows[i].Cells[j].Text == "质" || GridView1.Rows[i].Cells[j].Text == "合")
                {
                    GridView1.Rows[i].Cells[j].BackColor = System.Drawing.Color.FromArgb(221, 000, 000);
                    GridView1.Rows[i].Cells[j].ForeColor = System.Drawing.Color.White;
                }
            }
        }
    }

    protected void RadioButton1_CheckedChanged1(object sender, EventArgs e)
    {
        DataTable dt = BLL.X7_ZH_SeleteByNum(100);
        GridView1.DataSource = dt;
        GridView1.DataBind();
        ColorBind();
    }
    protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
    {
        DataTable dt = BLL.X7_ZH_SeleteByNum(50);
        GridView1.DataSource = dt;
        GridView1.DataBind();
        ColorBind();

    }
    protected void RadioButton3_CheckedChanged(object sender, EventArgs e)
    {
        DataTable dt = BLL.X7_ZH_SeleteByNum(30);
        GridView1.DataSource = dt;
        GridView1.DataBind();
        ColorBind();
    }
    protected void RadioButton4_CheckedChanged1(object sender, EventArgs e)
    {
        DataTable dt = BLL.X7_ZH_SeleteByNum(20);
        GridView1.DataSource = dt;
        GridView1.DataBind();
        ColorBind();
    }
    protected void RadioButton5_CheckedChanged1(object sender, EventArgs e)
    {
        DataTable dt = BLL.X7_ZH_SeleteByNum(10);
        GridView1.DataSource = dt;
        GridView1.DataBind();
        ColorBind();
    }

    protected void GridView1_RowCreated(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.Footer)
        {
            e.Row.SetRenderMethodDelegate(new RenderMethod(DrawGridFooter));
        }

        if (e.Row.RowType == DataControlRowType.Header)
        {
            e.Row.SetRenderMethodDelegate(new RenderMethod(DrawGridHeader));
        }
    }

    protected void DrawGridHeader(HtmlTextWriter output, Control ctl)
    {
        output.Write("<td rowspan ='2' align ='center' vlign='middle'>期  数</td>");
        output.Write("<td rowspan ='2'>开奖号码</td>");
        output.Write("<td colspan = '5'>第一位</td>");
        output.Write("<td colspan = '5'>第二位</td>");
        output.Write("<td colspan = '5'>第三位</td>");
        output.Write("<td colspan = '5'>第四位</td>");
        output.Write("<td colspan = '5'>第五位</td>");
        output.Write("<td colspan = '5'>第六位</td>");
        output.Write("<td colspan = '5'>第七位</td>");

        output.Write("<tr align ='center' vlign='center'>");
        for (int i = 0; i < 7; i++)
        {
            output.Write("<td>&nbsp;</td>");
            output.Write("<td>质</td>");
            output.Write("<td>&nbsp;</td>");
            output.Write("<td>合</td>");
            output.Write("<td>&nbsp;</td>");
        }
    }

    protected void DrawGridFooter(HtmlTextWriter output, Control ctl)
    {
        output.Write("<td colspan='2' rowspan='5'>预测方法：<br>用鼠标点击<br>方格即可显示<br>为开奖号色</td>");

        output.Write("<td bgcolor='#FCDFC5'>&nbsp;</td>");
        output.Write("<td bgcolor='#FCDFC5'onClick=Style(this,'#DD0000','#FCDFC5') style='color:#FCDFC5'>质</td>");
        output.Write("<td bgcolor='#FCDFC5'>&nbsp;</td>");
        output.Write("<td bgcolor='#FCDFC5'onClick=Style(this,'#DD0000','#FCDFC5') style='color:#FCDFC5'>合</td>");
        output.Write("<td bgcolor='#FCDFC5'>&nbsp;</td>");

        for (int i = 0; i < 3; i++)
        {
            output.Write("<td bgcolor='#DDFFE6'>&nbsp;</td>");
            output.Write("<td bgcolor='#DDFFE6'onClick=Style(this,'#DD0000','#DDFFE6') style='color:#DDFFE6'>质</td>");
            output.Write("<td bgcolor='#DDFFE6'>&nbsp;</td>");
            output.Write("<td bgcolor='#DDFFE6'onClick=Style(this,'#DD0000','#DDFFE6') style='color:#DDFFE6'>合</td>");
            output.Write("<td bgcolor='#DDFFE6'>&nbsp;</td>");

            output.Write("<td bgcolor='#C1E7FF'>&nbsp;</td>");
            output.Write("<td bgcolor='#C1E7FF'onClick=Style(this,'#DD0000','#C1E7FF') style='color:#C1E7FF'>质</td>");
            output.Write("<td bgcolor='#C1E7FF'>&nbsp;</td>");
            output.Write("<td bgcolor='#C1E7FF'onClick=Style(this,'#DD0000','#C1E7FF') style='color:#C1E7FF'>合</td>");
            output.Write("<td bgcolor='#C1E7FF'>&nbsp;</td>");
        }

        for (int j = 0; j < 4; j++)
        {
            output.Write("<tr align='center' valign='middle'>");

            output.Write("<td bgcolor='#FCDFC5'>&nbsp;</td>");
            output.Write("<td bgcolor='#FCDFC5'onClick=Style(this,'#DD0000','#FCDFC5') style='color:#FCDFC5'>质</td>");
            output.Write("<td bgcolor='#FCDFC5'>&nbsp;</td>");
            output.Write("<td bgcolor='#FCDFC5'onClick=Style(this,'#DD0000','#FCDFC5') style='color:#FCDFC5'>合</td>");
            output.Write("<td bgcolor='#FCDFC5'>&nbsp;</td>");

            for (int i = 0; i < 3; i++)
            {
                output.Write("<td bgcolor='#DDFFE6'>&nbsp;</td>");
                output.Write("<td bgcolor='#DDFFE6'onClick=Style(this,'#DD0000','#DDFFE6') style='color:#DDFFE6'>质</td>");
                output.Write("<td bgcolor='#DDFFE6'>&nbsp;</td>");
                output.Write("<td bgcolor='#DDFFE6'onClick=Style(this,'#DD0000','#DDFFE6') style='color:#DDFFE6'>合</td>");
                output.Write("<td bgcolor='#DDFFE6'>&nbsp;</td>");

                output.Write("<td bgcolor='#C1E7FF'>&nbsp;</td>");
                output.Write("<td bgcolor='#C1E7FF'onClick=Style(this,'#DD0000','#C1E7FF') style='color:#C1E7FF'>质</td>");
                output.Write("<td bgcolor='#C1E7FF'>&nbsp;</td>");
                output.Write("<td bgcolor='#C1E7FF'onClick=Style(this,'#DD0000','#C1E7FF') style='color:#C1E7FF'>合</td>");
                output.Write("<td bgcolor='#C1E7FF'>&nbsp;</td>");
            }
        }


        output.Write("<tr align='center' vlign = 'middle'>");
        output.Write("<td>&nbsp</td>");
        output.Write("<td>&nbsp</td>");
        output.Write("<td bgcolor='#FCDFC5'>&nbsp;</td>");
        output.Write("<td bgcolor='#FCDFC5'><font color='DD0000'>质</font></td>");
        output.Write("<td bgcolor='#FCDFC5'>&nbsp;</td>");
        output.Write("<td bgcolor='#FCDFC5'><font color='DD0000'>合</font></td>");
        output.Write("<td bgcolor='#FCDFC5'>&nbsp;</td>");

        for (int k = 0; k < 3; k++)
        {
            output.Write("<td bgcolor='#DDFFE6'>&nbsp;</td>");
            output.Write("<td bgcolor='#DDFFE6'><font color='DD0000'>质</font></td>");
            output.Write("<td bgcolor='#DDFFE6'>&nbsp;</td>");
            output.Write("<td bgcolor='#DDFFE6'><font color='DD0000'>合</font></td>");
            output.Write("<td bgcolor='#DDFFE6'>&nbsp;</td>");

            output.Write("<td bgcolor='#C1E7FF'>&nbsp;</td>");
            output.Write("<td bgcolor='#C1E7FF'><font color='DD0000'>质</font></td>");
            output.Write("<td bgcolor='#C1E7FF'>&nbsp;</td>");
            output.Write("<td bgcolor='#C1E7FF'><font color='DD0000'>合</font></td>");
            output.Write("<td bgcolor='#C1E7FF'>&nbsp;</td>");
        }

        output.Write("<tr align='center' vlign='center'>");
        output.Write("<td>期  数</td>");
        output.Write("<td>开奖号码</td>");
        output.Write("<td colspan ='5'bgcolor='#FFC9C8'>第一位</td>");
        output.Write("<td colspan ='5'bgcolor='#DDFFE6'>第二位</td>");
        output.Write("<td colspan ='5'bgcolor='#C1E7FF'>第三位</td>");
        output.Write("<td colspan ='5'bgcolor='#C1E7FF'>第四位</td>");
        output.Write("<td colspan ='5'bgcolor='#C1E7FF'>第五位</td>");
        output.Write("<td colspan ='5'bgcolor='#C1E7FF'>第六位</td>");
        output.Write("<td colspan ='5'bgcolor='#C1E7FF'>第七位</td>");

    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class Home_Room_OnlinePay_Alipay02_Send_YeePay : RoomPageBase
{
    public string Balance;
    public string UserName;
    public string BankName;

   

    public double Money = 0;
    public double RealPayMoney = 0;
    SystemOptions so = new SystemOptions();
    public long BuyID = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        BuyID = Shove._Convert.StrToLong(Shove._Web.Utility.GetRequest("BuyID"), 0);

        if (_User != null)
        {
            Balance = _User.Balance.ToString();
            UserName = _User.Name.ToString();
        }

        int OnlinePayType = Shove._Web.WebConfig.GetAppSettingsInt("OnlinePayType", 2);

        if (OnlinePayType == 1)
        {
            Response.Redirect("../Alipay01/Default.aspx", true);

            return;
        }

    }

    #region Web 窗体设计器生成的代码

    protected override void OnLoad(EventArgs e)
    {
        isRequestLogin = true;

        RequestLoginPage = this.Request.Url.AbsoluteUri;

        isAllowPageCache = false;

        base.OnLoad(e);
    }

    #endregion

    protected void btnNext_Click(object sender, System.EventArgs e)
    {
        string Money = this.PayMoney.Text;

        if (Shove._Convert.StrToDouble(Money, 0) <= 0)
        {
            Shove._Web.JavaScript.Alert(this.Page, "请输入正确的充值金额！再提交，谢谢！");
            return;
        }

        if (Shove._Convert.StrToDouble(Money, 0) < 2)
        {
            Shove._Web.JavaScript.Alert(this.Page, "存入金额最少2元, 请输入正确的充值金额！再提交，谢谢！");
            return;
        }

        lbPayMoney.Text = this.PayMoney.Text;

        BankName = "yeepay";
        hlOK.NavigateUrl = "../YeePay/Send.aspx?PayMoney=" + this.PayMoney.Text;


        pnlFirst.Visible = false;
        pnlSecond.Visible = true;
    }
}
﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="play_7201.aspx.cs" Inherits="Help_play_7201" %>

<%@ Register Src="../UserControls/PlayType.ascx" TagName="Help" TagPrefix="uc2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>竞彩足球-让分胜平负玩法介绍-手机买彩票！ </title>
    <meta name="keywords" content="胜负彩彩票玩法介绍" />
    <meta name="description" content="提供胜负彩彩票玩法介绍" />
    <link href="../Style/dahecp.css" rel="stylesheet" type="text/css" />
    <link rel="shortcut icon" href="../favicon.ico" />
</head>
<body>
    <form id="form1" runat="server">
    <asp:PlaceHolder ID="phHead" runat="server"></asp:PlaceHolder>
    <div id="user">
        <div id="user_l">
            <uc2:Help ID="Help" runat="server" />
        </div>
        <div id="user_r">
            <table border="0" cellpadding="0" cellspacing="0" style="margin-top: 10px;" width="842">
                <tr>
                    <td height="30" width="20">
                        &nbsp;
                    </td>
                    <td align="center" width="90" id="tdHelpCenter" style="cursor: hand; background-color: #E4E4E4;"
                        class="hui14">
                        <a href="Help_Default.aspx">帮助中心</a>
                    </td>
                    <td width="5">
                        &nbsp;
                    </td>
                    <td align="center" width="90" id="tdPlayType" style="cursor: hand; background-color: #FF6600;"
                        class="bai14">
                        <a href="Play_Default.aspx">玩法介绍</a>
                    </td>
                    <td>
                        &nbsp;
                    </td>
                </tr>
                <tr>
                    <td bgcolor="#FF6600" colspan="5" height="2">
                    </td>
                </tr>
            </table>
            <table width="100%" border="0" cellspacing="0" cellpadding="0" style="padding-top: 20px;">
                <tr>
                    <td height="36" align="center" class="red20">
                        竞彩足球-让分胜平负
                    </td>
                </tr>
                <tr>
                    <td height="0">
                    </td>
                </tr>
            </table>
            <table width="100%" border="0" cellpadding="0" cellspacing="1" bgcolor="#C0DBF9">
                <tr bgcolor="#CCCCCC">
                    <td bgcolor="#ffffff" class="black12" style="padding: 20px 25px 20px 25px; background-image: url(../images/zfb_bg_blue.jpg);
                        background-repeat: repeat-x; background-position: center top;">
                        <p>
                            <h3>
                                第一章 总 则</h3>
                            <p>
                                第一条 根据财政部《彩票发行与销售管理暂行规定》（财综[2002]13号）的有关规定，制定本游戏规则。</p>
                            <p>
                                第二条 中国足球彩票单场竞猜胜平负游戏（以下简称"单场胜平负游戏"）由国家体育总局体育彩票管理中心统一发行。</p>
                            <p>
                                第三条 "单场胜平负游戏"实行自愿购买，凡购买该彩票者即被视为同意并遵守本规则。</p>
                            <h3>
                                第二章 游戏方法</h3>
                            <p>
                                第四条 "单场胜平负游戏"以国家体育总局体育彩票管理中心选定的国际重要足球比赛为竞猜对象，由购票人对指定的比赛场次在全场90分钟（含伤停补时）的比赛结果进行投注。每一场比赛设置3种比赛结果选项：<br />
                                &nbsp;&nbsp;（一）"胜"：表示主队胜，客队负；<br />
                                &nbsp;&nbsp;（二）"平"：表示主队与客队平；<br />
                                &nbsp;&nbsp;（三）"负"：表示主队负，客队胜。<br />
                                购买"单场胜平负游戏"时，选择1场比赛投注为单场投注，选择2场或2场以上比赛投注为过关投注。<br />
                                投注方式包括单式投注和复式投注。其中，对所选比赛场次的比赛结果均选择1种投注结果为单式投注。对于某个或某几个比赛场次选择2种或2种以上的投注结果为复式投注。<br />
                                购票人可对其选定的结果进行多倍投注，投注倍数范围为2至99倍。</p>
                            <p>
                                第五条 当进行比赛的两支球队强弱悬殊较大时，由国家体育总局体育彩票管理中心根据实际比赛情况采用让球方式确定胜平负关系。具体让球球队及让球数量和竞猜赛程一同公布。<br />
                                例如：<br />
                                &nbsp;&nbsp;主队让1球。<br />
                                &nbsp;&nbsp;1、"胜" 主队得分减去客队得分大于1时，主队胜，客队负；<br />
                                &nbsp;&nbsp;2、"平" 主队得分减去客队得分等于1时，主队与客队平；<br />
                                &nbsp;&nbsp;3、"负" 主队得分减去客队得分小于1时，主队负，客队胜。<br />
                                &nbsp;&nbsp;客队让3球。<br />
                                &nbsp;&nbsp;1、"胜" 客队得分减去主队得分小于3时，主队胜，客队负；<br />
                                &nbsp;&nbsp;2、"平" 客队得分减去主队得分等于3时，主队与客队平；<br />
                                &nbsp;&nbsp;3、"负" 客队得分减去主队得分大于3时，主队负，客队胜。</p>
                            <p>
                                第六条 "单场胜平负游戏"每注2元，单张彩票最大投注金额不超过20000元。彩票不记名、不挂失，不返还本金，不流通使用。</p>
                            <p>
                                第七条 投注内容由购票人选定，通过销售终端机人工输入进行投注或利用"单场胜平负游戏"销售终端提供的投注单辅助进行投注。投注内容经投注系统确认后打印出的兑奖凭证即为"单场胜平负游戏"彩票，交购票人保存。</p>
                            <p>
                                第八条 投注单投注：<br />
                                （一）投注单有4个供购票人填写的独立区域，分别为"过关方式"区、"赛事编号"区、"竞猜选项"区、"倍数"区。<br />
                                "过关方式"区的格式为："选择竞猜场次数量 * 购买彩票注数"，购票人必须且只能选择单场投注或过关投注中的1种方式，不选或多选均为无效投注。<br />
                                具体投注注数的分配如下表：<br />
                                <img src="images/spf.jpg" alt="竞彩足球胜平负" /><br />
                                每个比赛场次所提供的过关投注方式由国家体育总局体育彩票管理中心选定，根据不同比赛场次情况，提供前表中全部或部分过关投注方式。<br />
                                "赛事编号"区：购票人填写所要竞猜的比赛场次的对应编号，包括日号和数字编号两部分。<br />
                                "竞猜选项"区：购票人对所选择的比赛场次的比赛结果进行投注，选择1个以上的结果即构成复式投注。所选择的场次数量应与"过关方式"区中所选择的竞猜场次数量一致，否则为无效投注。<br />
                                "倍数"区：此区域如不做出选择即为没有加倍投注；选择某项或某几项的组合即为对应的加倍投注，例如选择"5"为5倍投注、选择"50"加"6"为56倍投注、选择"50"加"40"加"9"为99倍投注。选择的倍数项之和大于99倍为无效投注。</p>
                            <p>
                                第九条 销售终端打印出的"单场胜平负游戏"彩票为该游戏唯一兑奖凭证。投注单只用于辅助购票人投注，不作为兑奖凭证，也不作为购票人投注结果的间接证明。</p>
                            <h3>
                                第三章 设 奖</h3>
                            <p>
                                第十条 奖金分配办法如下：<br />
                                （一）选择单场投注时，设置浮动奖金。<br />
                                单注奖金=2元×所选比赛场次的浮动奖金额。<br />
                                浮动奖金额=该比赛场次的单场投注总投注金额÷该比赛场次的单场投注中奖彩票总投注金额×68％。<br />
                                例如：选择第5场比赛竞猜，进行单场投注，则单注奖金=2元×浮动奖金额5，浮动奖金额5=第5场比赛的单场投注总投注金额÷第5场比赛的单场投注中奖彩票总投注金额×68％。<br />
                                （二）选择2场及2场以上过关投注时，设置固定奖金。国家体育总局体育彩票管理中心在每场选定比赛开始销售前，通过专用计算机分析系统，对每种有效的投注组合设一个固定奖金。该固定奖金在销售过程中根据投注额和其他相关因素调整，并通过销售系统和其他指定方式予以公布。购票人在完成有效投注时刻所获得的某个投注组合对应的固定奖金即为该有效投注中奖后的奖金。</p>
                            <p>
                                第十一条 "单场胜平负游戏"根据投注场次数量限定过关投注的单注彩票最高奖金限额，具体为：<br />
                                2场或3场过关投注，单注最高奖金限额20万元。<br />
                                4场或5场过关投注，单注最高奖金限额50万元。<br />
                                6场及6场以上过关投注，单注最高奖金限额100万元。<br />
                                彩票中奖后，若单注应兑奖金高于对应的最高奖金限额，则只兑付对应的最高限额奖金。</p>
                            <h3>
                                第四章 奖金管理</h3>
                            <p>
                                第十二条 "单场胜平负游戏"奖金为销售额的69％，其中68％为返奖奖金、1％为调节基金；公益金为销售额的18％；发行费为销售额的13％。</p>
                            <p>
                                第十三条 "单场胜平负游戏" 设置奖池，奖池由每个竞猜场次的应计提奖金与实际中出奖金的差额累计而成。当某个竞猜场次的应计提奖金大于其实际中出奖金时，余额滚入奖池；当单场投注奖金没有中出时，未中出奖金滚入奖池。当某个竞猜场次的应计提奖金小于其实际中出奖金时，差额用奖池补足；若奖池不足时，用调节基金补足，调节基金不足时，从发行经费中垫支。在出现发行费垫支的情况下，当奖池有资金滚入时优先偿还发行费垫支部分。</p>
                            <p>
                                第十四条 "单场胜平负游戏" 设置调节基金，调节基金由销售额的1％、浮动奖奖金取整后的余额、弃奖收入和逾期未退票的票款组成，专项用于支付不可预见情况下的奖金支出风险及设置特别奖。</p>
                            <p>
                                第十五条 "单场胜平负游戏"单注奖金不足2元补足至2元，补足部分从调节基金支出，调节基金不足时，从发行经费中垫支。在出现发行费垫支的情况下，当调节基金有资金滚入时优先偿还发行费垫支部分。</p>
                            <p>
                                第十六条 "单场胜平负游戏"之奖池、调节基金与其它中国足球彩票单场竞猜游戏之奖池、调节基金统一管理，相互间可调剂使用。</p>
                            <h3>
                                第五章 开奖及公告</h3>
                            <p>
                                第十七条 "单场胜平负游戏"在竞猜的比赛场次结束后，根据实际比赛结果进行开奖。实际比赛结果以当值裁判员在本规则涉及的比赛时长结束时刻裁定的比赛结果为准，其后对比赛结果的各类更改不影响原确认的开奖结果。开奖结果、销售情况等信息，通过销售网点和指定的互联网网站及其他媒体等信息渠道向社会公布。</p>
                            <h3>
                                第六章 中 奖</h3>
                            <p>
                                第十八条 每注"单场胜平负游戏"有效投注与对应开奖结果对照，与开奖结果一致即为中奖。</p>
                            <p>
                                第十九条 在 "单场胜平负游戏"销售过程中，如遇以下情形发生，则特别规定如下：<br />
                                （一）在某个比赛场次开始销售前，其比赛时间提前或推迟或取消比赛，则相应更改该比赛场次的开始、截止销售时间或取消该比赛场次竞猜。<br />
                                （二）在某个比赛场次开始销售后，若其比赛时间提前，则相应提前该比赛场次的截止销售时间。<br />
                                （三）在某个比赛场次开始销售后，若其比赛时间提前，且比赛开始时仍在进行销售，则认定该比赛场次对于在比赛开始时刻前发生的投注为有效场次，所涉及投注可正常参与兑奖；认定该比赛场次对于在比赛开始时刻后发生的投注则为无效场次。<br />
                                （四）在某个比赛场次开始销售后，若其比赛时间推迟且未超过原定时间36小时，则相应推迟该比赛场次的截止销售时间。<br />
                                （五）在某个比赛场次开始销售后，若其比赛时间推迟且超过原定时间36小时或无法获知具体推迟时间或取消比赛，则认定该比赛场次为无效场次。<br />
                                （六）若某个比赛场次在比赛进行中因故中断，且自中断时刻起36小时内继续完成了比赛，则认定该比赛场次为有效场次，所涉及投注可正常参与兑奖。<br />
                                （七）若某个比赛场次在比赛进行中因故中断，且自中断时刻起36小时内未继续完成比赛或无法获知具体补赛时间或取消补赛，则认定该比赛场次为无效场次。<br />
                                （八）在某个比赛场次开始销售后，如果比赛主办方决定更换比赛场地，若是从一中立比赛场地更换至另一中立比赛场地，则认定该比赛场次为有效场次，所涉及投注可正常参与兑奖；若不符合前述更换条件，则认定该比赛场次为无效场次。<br />
                                （九）在某个比赛场次开始销售后，若参赛双方中有一方与原定参赛队伍不同，则认定该比赛场次为无效场次。<br />
                                （十）在某个比赛场次开始销售后，若比赛主办方决定在无观众、无转播的封闭条件下进行比赛，则认定该比赛场次为无效场次。<br />
                                （十一）对上述无效场次的认定由国家体育总局体育彩票管理中心最终解释。<br />
                                （十二）当某场比赛被认定为无效场次，则该比赛场次的所有单场投注按退票处理，于28天内在指定地点办理退票手续；在过关投注中对该比赛场次的所有选择均视为无效，涉及该比赛场次的过关投注组合之固定奖金按在原投注时刻去除该比赛场次后的投注组合对应的固定奖金计算。<br />
                                （十三）在某个比赛场次销售过程中，国家体育总局体育彩票管理中心可根据投注额、突发事件等因素，拒绝某些大额投注、暂停或提前截止针对该场比赛的某些特定过关组合特定结果选项的投注、暂停或提前截止针对该场比赛的所有投注。</p>
                            <p>
                                第二十条 每注彩票只有一次中奖机会，不兼中兼得。</p>
                            <h3>
                                第七章 兑 奖</h3>
                            <p>
                                第二十一条 "单场胜平负游戏"中奖者到当地指定的彩票机构或投注站进行兑奖。每张彩票所涉及的所有比赛场次的开奖结果全部公布后次日起28天为兑奖期，逾期未兑，视为弃奖。</p>
                            <p>
                                第二十二条 彩票机构和投注站进行兑奖时，有权查验中奖者的中奖彩票及有效身份证件，兑奖者应予配合。</p>
                            <p>
                                第二十三条 凡伪造、涂改中奖彩票，冒领奖金者，送交司法机关追究法律责任。</p>
                            <h3>
                                第八章 附 则</h3>
                            <p>
                                第二十四条 规则执行中有关重大事项，将通过销售系统和其他指定方式予以公布，国家体育总局体育彩票管理中心不再承担直接通知购票人的责任，购票人须自行知晓。</p>
                        </p>
                    </td>
                </tr>
            </table>
        </div>
    </div>
    <asp:PlaceHolder ID="phFoot" runat="server"></asp:PlaceHolder>
    </form>
    <!--#includefile="../Html/TrafficStatistics/1.htm"-->
</body>
</html>

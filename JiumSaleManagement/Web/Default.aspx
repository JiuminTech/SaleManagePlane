<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Jium.Web.Default" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>门店销售管理系统</title>
    <link href="~/css/weixincss" type="text/css" rel="stylesheet" />
    <style type="text/css"> 
.Tab
{
display:block;
white-space:nowrap;
width:100%;
overflow:auto;
}
.Tab li
{
width:80px;
height:30px;
margin:1px;
background:green;
display:inline-block;
}
.Tab li .Selected
{
width:80px;
height:30px;
margin:1px;
background:gray;
display:inline-block;
}
</style>
    <script language="javascript" src="/js/tabControl.js" type="text/javascript"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div class="row">
        <div id="Content-Main" class="col-md-12">            
            <div class="WeChatNews">
                <div class="Tab">
                    <ul>                        
                        <li><a id="T1" onclick="setTab('T',1,10)" href="javascript:void(0)" class="Selected">销售</a></li>
                        <li><a id="T7" onclick="setTab('T',7,10)" href="javascript:void(0)">销售记录</a></li>
                        <li><a id="T2" onclick="setTab('T',2,10)" href="javascript:void(0)">库存</a></li>
                        <li><a id="T3" onclick="setTab('T',3,10)" href="javascript:void(0)">产品</a></li>
                        <li><a id="T5" onclick="setTab('T',5,10)" href="javascript:void(0)">产品组合</a></li>
                        <br />                               
                        <li><a id="T4" onclick="setTab('T',4,10)" href="javascript:void(0)">会员</a></li> 
                        <li><a id="T8" onclick="setTab('T',8,10)" href="javascript:void(0)">预约记录</a></li>                        
                        <li><a id="T6" onclick="setTab('T',6,10)" href="javascript:void(0)">服务类型</a></li>
                        <li><a id="T10" onclick="setTab('T',10,10)" href="javascript:void(0)">员工信息</a></li>
                        <li><a id="T9" onclick="setTab('T',9,10)" href="javascript:void(0)">排班计划</a></li>
                    </ul>
                </div>
                <div class="TabCon">
                    <div id="conT1">
                        <div class="MsgEditor" id="subcribe">
                            <iframe class="mainIframe" id="mainIfram" name="iframe_m" src='piorecord/sale.aspx' allowtransparency="true" style="background-color:lightgray; width:100%; height:500px " title="test" frameborder="1" scrolling="yes">
                                您的浏览器不支持嵌入式框架，或者当前配置为不显示嵌入式框架。
                            </iframe>
                        </div>
                    </div>
                    <div id="conT2" style="display: none;">
                        <div class="MsgEditor" id="autoresp">
                            <iframe class="mainIframe" id="mainIframb" name="iframe_m" src='plib/list.aspx' allowtransparency="true" style="background-color:lightgray; width:100%; height:500px " title="test" frameborder="1" scrolling="yes">
                                您的浏览器不支持嵌入式框架，或者当前配置为不显示嵌入式框架。
                            </iframe>
                        </div>
                    </div>
                    <div id="conT3" style="display: none;">
                        <div class="MsgEditor" id="subcribeb">
                            <iframe class="mainIframe" id="mainIframc" name="iframe_m" src='product/list.aspx' allowtransparency="true" style="background-color:lightgray; width:100%; height:500px " title="test" frameborder="1" scrolling="yes">
                                您的浏览器不支持嵌入式框架，或者当前配置为不显示嵌入式框架。
                            </iframe>

                        </div>
                    </div>
                    <div id="conT4" style="display: none;">
                        <iframe class="mainIframe" id="mainIframd" name="iframe_m" src='consumer/list.aspx' allowtransparency="true" style="background-color:lightgray; width:100%; height:500px" title="weibo" frameborder="1" scrolling="yes">
                            您的浏览器不支持嵌入式框架，或者当前配置为不显示嵌入式框架。
                        </iframe>
                    </div>
                    <div id="conT5" style="display: none;">
                        <iframe class="mainIframe" id="mainIframe" name="iframe_m" src='pgroup/list.aspx' allowtransparency="true" style="background-color:lightgray; width:100%; height:500px" title="weibo" frameborder="1" scrolling="yes">
                            您的浏览器不支持嵌入式框架，或者当前配置为不显示嵌入式框架。
                        </iframe>
                    </div>
                    <div id="conT6" style="display: none;">
                        <iframe class="mainIframe" id="mainIframf" name="iframe_m" src='servicetype/list.aspx' allowtransparency="true" style="background-color:lightgray; width:100%; height:500px" title="weibo" frameborder="1" scrolling="yes">
                            您的浏览器不支持嵌入式框架，或者当前配置为不显示嵌入式框架。
                        </iframe>
                    </div>
                    <div id="conT7" style="display: none;">
                        <iframe class="mainIframe" id="mainIframg" name="iframe_m" src='piorecord/list.aspx' allowtransparency="true" style="background-color:lightgray; width:100%; height:500px" title="weibo" frameborder="1" scrolling="yes">
                            您的浏览器不支持嵌入式框架，或者当前配置为不显示嵌入式框架。
                        </iframe>
                    </div>
                    <div id="conT8" style="display: none;">
                        <iframe class="mainIframe" id="mainIframgh" name="iframe_m" src='servicerorder/list.aspx' allowtransparency="true" style="background-color:lightgray; width:100%; height:500px" title="weibo" frameborder="1" scrolling="yes">
                            您的浏览器不支持嵌入式框架，或者当前配置为不显示嵌入式框架。
                        </iframe>
                    </div>
                    <div id="conT9" style="display: none;">
                        <iframe class="mainIframe" id="mainIframi" name="iframe_m" src='serviceplan/list.aspx' allowtransparency="true" style="background-color:lightgray; width:100%; height:500px" title="weibo" frameborder="1" scrolling="yes">
                            您的浏览器不支持嵌入式框架，或者当前配置为不显示嵌入式框架。
                        </iframe>
                    </div>
                    <div id="conT10" style="display: none;">
                        <iframe class="mainIframe" id="mainIframj" name="iframe_m" src='userinfo/list.aspx' allowtransparency="true" style="background-color:lightgray; width:100%; height:500px" title="weibo" frameborder="1" scrolling="yes">
                            您的浏览器不支持嵌入式框架，或者当前配置为不显示嵌入式框架。
                        </iframe>
                    </div>
                </div>
            </div>
            
        </div>        
    </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Jium.Web.Default" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>门店销售管理系统1</title>
    <link href="~/css/weixincss" type="text/css" rel="stylesheet" />
    <script language="javascript" src="/js/tabControl.js" type="text/javascript"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div class="row">
        <div id="Content-Main" class="col-md-12">            
            <div class="WeChatNews">
                <div class="Tab">
                    <ul>
                        <li><a id="T1" onclick="setTab('T',1,4)" href="javascript:void(0)" class="Selected">销售</a></li>
                        <li><a id="T2" onclick="setTab('T',2,4)" href="javascript:void(0)">库存</a></li>
                        <li><a id="T3" onclick="setTab('T',3,4)" href="javascript:void(0)">产品</a></li>
                        <li><a id="T4" onclick="setTab('T',4,4)" href="javascript:void(0)">会员</a></li>
                        
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
                </div>
            </div>
            
        </div>        
    </div>
    </form>
</body>
</html>

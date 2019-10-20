<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="Jium.Web.piorecord.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		序号
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblid" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		日期
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblptime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		货号
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblpcode" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		数量
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblpcnt" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		标价
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblpsaleprice" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		售价
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblprealprice" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		分类
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblptype" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		折扣系数
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblpzekou" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		备注
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblpremark" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		顾客ID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblpguestid" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		售货员ID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblpsalerid" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		来源
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblpios1" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		存放点
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblpios2" runat="server"></asp:Label>
	</td></tr>
	<!--<tr>
	<td height="25" width="30%" align="right">
		pios3
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblpios3" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		pios4
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblpios4" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		pios5
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblpios5" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		piod1
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblpiod1" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		piod2
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblpiod2" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		piod3
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblpiod3" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		piod5
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblpiod5" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		piod4
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblpiod4" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		piodc1
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblpiodc1" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		piodc2
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblpiodc2" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		piodc3
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblpiodc3" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		piodc4
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblpiodc4" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		piodc5
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblpiodc5" runat="server"></asp:Label>
	</td></tr>-->
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>





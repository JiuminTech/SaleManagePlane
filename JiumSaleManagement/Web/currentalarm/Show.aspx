<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="Jium.Web.currentalarm.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		auto_increment
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblid" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		alarmname
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblalarmname" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		alarmdesc
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblalarmdesc" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		createtime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcreatetime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		updatetime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblupdatetime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ownerid
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblownerid" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		handlerid
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblhandlerid" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		alarmtype
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblalarmtype" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		operateid
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbloperateid" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		handlestatus
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblhandlestatus" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		confirmtime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblconfirmtime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		handledetail
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblhandledetail" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>





<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="Jium.Web.clerk.Show" Title="显示页" %>
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
		cname
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcname" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		cphone
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcphone" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		cemail
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcemail" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		csex
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcsex" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		clevel
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblclevel" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ccode
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblccode" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		caddress
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcaddress" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		csalesum
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcsalesum" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		cremark
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcremark" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		cls1
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcls1" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		cls2
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcls2" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		cls3
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcls3" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		cls4
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcls4" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		cls5
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcls5" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		cld1
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcld1" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		cld2
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcld2" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		cld3
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcld3" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		cld4
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcld4" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		cld5
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcld5" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		cldc1
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcldc1" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		cldc2
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcldc2" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		cldc3
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcldc3" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		cldc4
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcldc4" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		cldc5
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcldc5" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>





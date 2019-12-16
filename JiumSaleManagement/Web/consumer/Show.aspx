<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="Jium.Web.consumer.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<%--<tr>
	<td height="25" width="30%" align="right">
		auto_increment
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblid" runat="server"></asp:Label>
	</td></tr>--%>
	<tr>
	<td height="25" width="30%" align="right">
		姓名
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcname" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		会员ID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblccode" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		手机号
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcphone" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Wxcode
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcemail" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		等级
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblclevel" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		消费总额
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcsum" runat="server"></asp:Label>
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
		备注
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcremark" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		更新日期
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcss1" runat="server"></asp:Label>
	</td></tr>
	<%--<tr>
	<td height="25" width="30%" align="right">
		css2
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcss2" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		css3
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcss3" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		css4
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcss4" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		css5
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcss5" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		csd1
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcsd1" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		csd2
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcsd2" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		csd3
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcsd3" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		csd4
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcsd4" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		csd5
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcsd5" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		csdc1
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcsdc1" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		csdc2
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcsdc2" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		csdc3
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcsdc3" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		csdc4
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcsdc4" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		csdc5
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcsdc5" runat="server"></asp:Label>
	</td></tr>--%>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>





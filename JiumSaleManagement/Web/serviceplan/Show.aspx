<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="Jium.Web.serviceplan.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		id
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblid" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		plandate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblplandate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		plantime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblplantime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		totalnum
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltotalnum" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		leftnum
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblleftnum" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		nexttotal
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblnexttotal" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		nextleft
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblnextleft" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		nextid
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblnextid" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		pss1
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblpss1" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		pss2
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblpss2" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		pss3
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblpss3" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		pss4
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblpss4" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		pss5
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblpss5" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		psd1
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblpsd1" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		psd2
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblpsd2" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		psd3
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblpsd3" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		psd4
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblpsd4" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		psd5
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblpsd5" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>





<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="Xwsw.Web.NMS.consumerservice.Show" Title="显示页" %>
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
		ccode
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblccode" runat="server"></asp:Label>
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
		cstype
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcstype" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		csnum
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcsnum" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		csleft
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcsleft" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		csiostatus
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcsiostatus" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		cstime0
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcstime0" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		cstime1
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcstime1" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		cstime2
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcstime2" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		cstime3
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcstime3" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		cstime4
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcstime4" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		cstime5
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcstime5" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		cstime6
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcstime6" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		cstime7
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcstime7" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		cstime8
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcstime8" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		cstime9
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcstime9" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		cstime10
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcstime10" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		css1
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcss1" runat="server"></asp:Label>
	</td></tr>
	<tr>
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
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>





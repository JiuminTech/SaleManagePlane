﻿<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="Jium.Web.consumer.Modify" Title="修改页" %>
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
		<asp:label id="lblid" runat="server"></asp:label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		cname
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcname" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ccode
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtccode" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		cphone
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcphone" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		cemail
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcemail" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		clevel
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtclevel" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		csum
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcsum" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		csex
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcsex" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		cremark
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcremark" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		css1
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcss1" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		css2
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcss2" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		css3
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcss3" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		css4
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcss4" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		css5
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcss5" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		csd1
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcsd1" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		csd2
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcsd2" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		csd3
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcsd3" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		csd4
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcsd4" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		csd5
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcsd5" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		csdc1
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcsdc1" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		csdc2
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcsdc2" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		csdc3
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcsdc3" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		csdc4
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcsdc4" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		csdc5
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcsdc5" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
</table>

            </td>
        </tr>
        <tr>
            <td class="tdbg" align="center" valign="bottom">
                <asp:Button ID="btnSave" runat="server" Text="保存"
                    OnClick="btnSave_Click" class="inputbutton" onmouseover="this.className='inputbutton_hover'"
                    onmouseout="this.className='inputbutton'"></asp:Button>
                <asp:Button ID="btnCancle" runat="server" Text="取消"
                    OnClick="btnCancle_Click" class="inputbutton" onmouseover="this.className='inputbutton_hover'"
                    onmouseout="this.className='inputbutton'"></asp:Button>
            </td>
        </tr>
    </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>


﻿<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="Jium.Web.eventtype.Show" Title="显示页" %>
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
		eventname
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbleventname" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		remark
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblremark" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		isnotify
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblisnotify" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		udatetime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbludatetime" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>





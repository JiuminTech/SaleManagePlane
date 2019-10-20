<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="Jium.Web.product.Modify" Title="修改页" %>
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
		pcode
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpcode" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		pname
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpname" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		psaleprice
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpsaleprice" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		prealprice
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtprealprice" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ptype
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtptype" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		pisgroup
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpisgroup" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		pdesc
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpdesc" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ps1
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtps1" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ps2
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtps2" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ps3
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtps3" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ps4
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtps4" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ps5
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtps5" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		pd1
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpd1" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		pd2
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpd2" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		pd3
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpd3" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		pd4
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpd4" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		pd5
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpd5" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		pdc1
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpdc1" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		pdc2
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpdc2" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		pdc3
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpdc3" runat="server" Width="200px"></asp:TextBox>
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


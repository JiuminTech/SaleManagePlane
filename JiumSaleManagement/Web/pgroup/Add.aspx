<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeBehind="Add.aspx.cs" Inherits="Jium.Web.pgroup.Add" Title="增加页" %>

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
		<asp:TextBox id="txtid" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		gid
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtgid" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		gindex
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtgindex" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		gpid
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtgpid" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		gpcnt
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtgpcnt" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		gdesc
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtgdesc" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		gs1
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtgs1" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		gs2
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtgs2" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		gs3
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtgs3" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		gs4
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtgs4" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		gs5
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtgs5" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		gd1
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtgd1" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		gd2
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtgd2" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		gd3
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtgd3" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		gd4
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtgd4" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		gd5
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtgd5" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		gdc1
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtgdc1" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		gdc2
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtgdc2" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		gdc3
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtgdc3" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		gdc4
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtgdc4" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		gdc5
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtgdc5" runat="server" Width="200px"></asp:TextBox>
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
    <br />
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>

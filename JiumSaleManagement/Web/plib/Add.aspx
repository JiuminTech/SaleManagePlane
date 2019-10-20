<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeBehind="Add.aspx.cs" Inherits="Jium.Web.plib.Add" Title="增加页" %>

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
		pdesc
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpdesc" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		pleftcnt
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpleftcnt" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		plupdatetime
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtplupdatetime" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		psumcnt
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpsumcnt" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		psalecnt
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpsalecnt" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		pls1
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpls1" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		pls2
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpls2" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		pls3
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpls3" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		pls4
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpls4" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		pls5
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpls5" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		pld1
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpld1" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		pld2
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpld2" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		pld3
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpld3" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		pld4
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpld4" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		pld5
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpld5" runat="server" Width="200px"></asp:TextBox>
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

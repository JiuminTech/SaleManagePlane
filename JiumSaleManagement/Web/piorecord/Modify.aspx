<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="Jium.Web.piorecord.Modify" Title="修改页" %>
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
		ptime
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtptime" runat="server" Width="200px"></asp:TextBox>
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
		pcnt
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpcnt" runat="server" Width="200px"></asp:TextBox>
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
		pzekou
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpzekou" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		premark
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpremark" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		pguestid
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpguestid" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		psalerid
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpsalerid" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		pios1
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpios1" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		pios2
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpios2" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		pios3
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpios3" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		pios4
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpios4" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		pios5
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpios5" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		piod1
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpiod1" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		piod2
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpiod2" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		piod3
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpiod3" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		piod5
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpiod5" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		piod4
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpiod4" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		piodc1
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpiodc1" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		piodc2
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpiodc2" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		piodc3
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpiodc3" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		piodc4
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpiodc4" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		piodc5
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpiodc5" runat="server" Width="200px"></asp:TextBox>
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


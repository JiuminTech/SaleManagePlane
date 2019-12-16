<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="Jium.Web.serviceplan.Modify" Title="修改页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    
    <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
        <tr>
            <td class="tdbg">
                
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		编号
	：</td>
	<td height="25" width="*" align="left">
		<asp:label id="lblid" runat="server"></asp:label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		日期
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtplandate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		时段
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtplantime" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		总容量
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttotalnum" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		余量
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtleftnum" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		下时段总容量
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtnexttotal" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		下时段余量
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtnextleft" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		下时段编号
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtnextid" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		下时段
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpss1" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<%--<tr>
	<td height="25" width="30%" align="right">
		pss2
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpss2" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		pss3
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpss3" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		pss4
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpss4" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		pss5
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpss5" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		psd1
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpsd1" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		psd2
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpsd2" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		psd3
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpsd3" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		psd4
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpsd4" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		psd5
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpsd5" runat="server" Width="200px"></asp:TextBox>
	</td></tr>--%>
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


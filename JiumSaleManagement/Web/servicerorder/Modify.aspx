<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="Jium.Web.servicerorder.Modify" Title="修改页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    
    <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
        <tr>
            <td class="tdbg">
                
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		订单ID
	：</td>
	<td height="25" width="*" align="left">
		<asp:label id="lblid" runat="server"></asp:label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		顾客ID
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtccode" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		预约ID
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtspid" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		人数
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtspnum" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		服务项数
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtspspan" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		状态
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtsostatus" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		创建时间
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcreatetime" runat="server" Width="200px" Enabled="false"></asp:TextBox>
	</td></tr>
	<%--<tr>
	<td height="25" width="30%" align="right">
		更新日期
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtupdatetime" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		更新人
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtupdateby" runat="server" Width="200px"></asp:TextBox>
	</td></tr>--%>
	<%--<tr>
	<td height="25" width="30%" align="right">
		sos1
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtsos1" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		sos2
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtsos2" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		sos3
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtsos3" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		sos4
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtsos4" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		sos5
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtsos5" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		sod1
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtsod1" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		sod2
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtsod2" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		sod3
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtsod3" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		sod4
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtsod4" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		sod5
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtsod5" runat="server" Width="200px"></asp:TextBox>
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


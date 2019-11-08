<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="Jium.Web.plib.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<%--<tr>
	<td height="25" width="30%" align="right">
		id
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblid" runat="server"></asp:Label>
	</td></tr>--%>
	<tr>
	<td height="25" width="20%" align="right">
		货号
	：</td>
	<td height="25" width="20%" align="left">
		<asp:Label id="lblpcode" runat="server"></asp:Label>
	</td>
        <td height="25" width="20%" align="right">
		名称
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblpname" runat="server"></asp:Label>
	</td>
	</tr>
	<tr>
	
	<td height="25" width="20%" align="right">
		单位
	：</td>
	<td height="25" width="20%" align="left">
		<asp:Label id="lblpls2" runat="server"></asp:Label>
	</td>
        <td height="25" width="20%" align="right">
		库存
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblpleftcnt" runat="server"></asp:Label>
	</td>
	</tr>
    <tr>
	<td height="25" width="20%" align="right">
		订单量
	：</td>
	<td height="25" width="20%" align="left">
		<asp:Label id="lblpld1" runat="server"></asp:Label>
	</td>
        <td height="25" width="20%" align="right">
		到货量
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblpsumcnt" runat="server"></asp:Label>
	</td>
    </tr>
	
	<tr>
	<td height="25" width="20%" align="right">
		销量
	：</td>
	<td height="25" width="20%" align="left">
		<asp:Label id="lblpsalecnt" runat="server"></asp:Label>
	</td>
        <td height="25" width="20%" align="right">
		更新时间
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblplupdatetime" runat="server"></asp:Label>
	</td>
	</tr>
	<tr>
	<td height="25" width="20%" align="right">
		位置
	：</td>
	<td height="25" width="20%" align="left">
		<asp:Label id="lblpls1" runat="server"></asp:Label>
	</td>        

	<td height="25" width="*" align="right">
		描述
	：</td>
	<td height="25" width="30%" align="left">
		<asp:Label id="lblpdesc" runat="server"></asp:Label>
	</td></tr>  
	<%--<tr>
	<td height="25" width="30%" align="right">
		pls3
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblpls3" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		pls4
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblpls4" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		pls5
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblpls5" runat="server"></asp:Label>
	</td></tr>
        <tr>
	<td height="25" width="30%" align="right">
		pld2
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblpld2" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		pld3
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblpld3" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		pld4
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblpld4" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		pld5
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblpld5" runat="server"></asp:Label>
	</td></tr>--%>
</table>

                    </td>
                </tr>
       <tr>
           <td>
                <br />
            <asp:GridView ID="gridView" runat="server" AllowPaging="True" Width="100%" CellPadding="3"  OnPageIndexChanging ="gridView_PageIndexChanging"
                    BorderWidth="1px" DataKeyNames="id" OnRowDataBound="gridView_RowDataBound"
                    AutoGenerateColumns="false" PageSize="10"  RowStyle-HorizontalAlign="Center" OnRowCreated="gridView_OnRowCreated">
                    <Columns>
                            
		<asp:BoundField DataField="ptime" HeaderText="日期" SortExpression="ptime" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="pcode" HeaderText="货号" SortExpression="pcode" ItemStyle-HorizontalAlign="Center"  /> 
                        <asp:BoundField DataField="pios3" HeaderText="名称" SortExpression="pios3" ItemStyle-HorizontalAlign="Center"  /> 
                        <asp:BoundField DataField="pios4" HeaderText="单位" SortExpression="pios4" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="pcnt" HeaderText="数量" SortExpression="pcnt" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="psaleprice" HeaderText="标价" SortExpression="psaleprice" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="prealprice" HeaderText="售价" SortExpression="prealprice" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ptype" HeaderText="分类" SortExpression="ptype" ItemStyle-HorizontalAlign="Center"  /> 
                        <asp:BoundField DataField="pios5" HeaderText="系列" SortExpression="pios5" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="pzekou" HeaderText="折扣系数" SortExpression="pzekou" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="premark" HeaderText="备注" SortExpression="premark" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="pguestid" HeaderText="顾客ID" SortExpression="pguestid" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="psalerid" HeaderText="售货员ID" SortExpression="psalerid" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="pios1" HeaderText="来源" SortExpression="pios1" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="pios2" HeaderText="存放点" SortExpression="pios2" ItemStyle-HorizontalAlign="Center"  /> 		
		
		
	<%--	<asp:BoundField DataField="piod1" HeaderText="piod1" SortExpression="piod1" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="piod2" HeaderText="piod2" SortExpression="piod2" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="piod3" HeaderText="piod3" SortExpression="piod3" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="piod5" HeaderText="piod5" SortExpression="piod5" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="piod4" HeaderText="piod4" SortExpression="piod4" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="piodc1" HeaderText="piodc1" SortExpression="piodc1" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="piodc2" HeaderText="piodc2" SortExpression="piodc2" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="piodc3" HeaderText="piodc3" SortExpression="piodc3" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="piodc4" HeaderText="piodc4" SortExpression="piodc4" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="piodc5" HeaderText="piodc5" SortExpression="piodc5" ItemStyle-HorizontalAlign="Center"  /> --%>
                            
                            <%--<asp:HyperLinkField HeaderText="详细" ControlStyle-Width="50" DataNavigateUrlFields="id" DataNavigateUrlFormatString="Show.aspx?id={0}"
                                Text="详细"  />
                            <asp:HyperLinkField HeaderText="编辑" ControlStyle-Width="50" DataNavigateUrlFields="id" DataNavigateUrlFormatString="Modify.aspx?id={0}"
                                Text="编辑"  />
                            <asp:TemplateField ControlStyle-Width="50" HeaderText="删除"   Visible="false"  >
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Delete"
                                         Text="删除"></asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>--%>
                        </Columns>
                </asp:GridView>               
           </td>
       </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>





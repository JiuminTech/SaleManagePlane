<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" CodeBehind="Sale.aspx.cs" Inherits="Jium.Web.piorecord.Sale" Title="销售页" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<script language="javascript" src="/js/CheckBox.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    
    <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
        <tr>
            <td class="tdbg">
                
<table cellspacing="0" cellpadding="0" width="100%" border="0">
    <tr>
	<td height="25" width="20%" align="right">
		手机号码
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtCphone" runat="server" Width="150px"></asp:TextBox>
        <asp:Button ID="btnSearchConsumer" runat="server" Text="查询"  OnClick="btnSearchConsumer_Click" ></asp:Button>
	</td>
        <td height="25" width="20%" align="right">
		姓名
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtCname" runat="server" Width="200px"  Enabled="false"></asp:TextBox>
	</td>
       
    </tr>
    <tr>
	<td height="25" width="20%" align="right">
		顾客ID
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtCcode" runat="server" Width="200px" Enabled="false"></asp:TextBox>
	</td>
        <td height="25" width="20%" align="right">
		总消费金额
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtSumMoney" runat="server" Width="200px" Enabled="false"></asp:TextBox>
	</td>        
    </tr>

    <tr>
	<td height="25" width="20%" align="right">
		商品总价
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtSumTotal" runat="server" Width="200px"></asp:TextBox>
	</td>
        <td height="25" width="20%" align="right">
		折扣系数
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtZekou" runat="server" Width="100px"></asp:TextBox>
        <asp:Button ID="ButtonAllZekou" runat="server" Text="整单折扣"  
                    OnClick="ButtonAllZekou_Click" class="inputbutton" onmouseover="this.className='inputbutton_hover'"
                    onmouseout="this.className='inputbutton'"></asp:Button>
	</td>
    </tr>
   
    <tr>
	<td height="25" width="20%" align="right">
		折后价
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtSumReal" runat="server" Width="200px"></asp:TextBox>
	</td>
        <td height="25" width="20%" align="right">
		支付类型
	：</td>
	<td height="25" width="*" align="left">
		<%--<asp:TextBox id="txtptype" runat="server" Width="200px"></asp:TextBox>--%>
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem Selected="True" Value="0"> 支付宝</asp:ListItem>
            <asp:ListItem Value="1">微信</asp:ListItem>
            <asp:ListItem Value="2">现金</asp:ListItem>
            <asp:ListItem Value="3">积分抵扣</asp:ListItem>
            <asp:ListItem Value="4">其他</asp:ListItem>
        </asp:DropDownList>
	</td>
    </tr> 
    <tr>
	<td height="25" width="20%" align="right">
		销售员ID
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="TextBox8" runat="server" Width="200px"></asp:TextBox>
	</td>
        <td height="25" width="20%" align="right">
		备注
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="TextBox7" runat="server" Width="200px"></asp:TextBox>
	</td>
    </tr>

</table>
                </td>
            </tr>
         <tr>
            <td class="tdbg" align="center" valign="bottom">
                <asp:Button ID="btnConfirmSale" runat="server" Text="销售确认"
                    OnClick="btnConfirmSale_Click" class="inputbutton" onmouseover="this.className='inputbutton_hover'"
                    onmouseout="this.className='inputbutton'"></asp:Button>
                <asp:Button ID="ButtonHold" runat="server" Text="挂起"
                    OnClick="btnProductHold_Click" class="inputbutton" onmouseover="this.className='inputbutton_hover'"
                    onmouseout="this.className='inputbutton'"></asp:Button>
                <asp:Button ID="btnCLear" runat="server" Text="清空"
                    OnClick="btnProductClear_Click" class="inputbutton" onmouseover="this.className='inputbutton_hover'"
                    onmouseout="this.className='inputbutton'"></asp:Button>
                <asp:LinkButton ID="LinkButtonBuyHistory" runat="server" PostDataFileds="id" Enabled="false"  Text="消费记录" PostBackUrl="~/piorecord/list.aspx"></asp:LinkButton>
         <asp:LinkButton ID="LinkButtonServiceHistory" runat="server" PostDataFileds="id"  Enabled="false" Text="服务记录" PostBackUrl="~/consumerservice/list.aspx"></asp:LinkButton>
                <asp:LinkButton ID="LinkButton1" runat="server"   Text="新增会员" PostBackUrl="~/consumer/Add.aspx"></asp:LinkButton>

            </td>
        </tr>
                 <tr>
            <td class="tdbg">
                <asp:GridView ID="gridViewBuy" runat="server" AllowPaging="False" Width="100%" CellPadding="3" 
                    BorderWidth="1px" DataKeyNames="id,pcode" onAdd="gridView_BuyAdd" OnRowDeleting="gridView_RowDeleting"
                    AutoGenerateColumns="false" PageSize="20"  RowStyle-HorizontalAlign="Center" EnableCellEditing="True">
                    <Columns>
		<asp:BoundField DataField="pcode" HeaderText="货号" SortExpression="pcode" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="pios3" HeaderText="名称" SortExpression="pname" ItemStyle-HorizontalAlign="Center"  />
       <asp:BoundField DataField="pios4" HeaderText="单位"  ItemStyle-HorizontalAlign="Center"  />

                        <asp:BoundField DataField="psaleprice" HeaderText="单价" SortExpression="psaleprice" ItemStyle-HorizontalAlign="Center"  />
          <asp:BoundField DataField="piod1" HeaderText="售后次数"  ItemStyle-HorizontalAlign="Center"  />               
		<asp:BoundField DataField="pcnt" HeaderText="购买量" SortExpression="psalecnt"  ItemStyle-HorizontalAlign="Center"  /> 
                        <asp:BoundField DataField="pzekou" HeaderText="折扣系数"  ItemStyle-HorizontalAlign="Center"  />

                            <asp:TemplateField ControlStyle-Width="100" HeaderText="操作"   Visible="true"  >
                                <ItemTemplate>
                                    <asp:Button ID="ButtonZekou" tag="pcode" runat="server" Text="调价"  OnClick="btnProductZekou_Click" >
                    </asp:Button>
                                    <asp:Button ID="ButtonProductAdd" tag="pcode" runat="server" Text="增加"  OnClick="btnProductAdd_Click" >
                    </asp:Button>
                                    <asp:Button ID="btnProductPlus" tag="pcode" runat="server" Text="减少"  OnClick="btnProductPlus_Click" >
                    </asp:Button>
                                    <asp:LinkButton ID="LinkButtonDelCur" runat="server" CausesValidation="False" CommandName="Delete"
                                         Text="移除"></asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                         
                        </Columns>
                </asp:GridView>

            </td>
        </tr>
       
        <tr>
            <td>
                <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>
                    <td style="width: 80px" align="right" class="tdbg">
                         <b>模糊查询：</b>
                    </td>
                    <td class="tdbg">                       
                    <asp:TextBox ID="txtKeyword" runat="server" PlaceHolder="货号/名称/描述"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnSearchProduct" runat="server" Text="货品查询"  OnClick="btnSearchProduct_Click" >
                    </asp:Button>
                    </td>                    
                    <td class="tdbg">
                    </td>
                </tr>
            </table>
            <!--Search end-->
            <br />
            <asp:GridView ID="gridViewLib" runat="server" AllowPaging="True" Width="100%" CellPadding="3"   OnPageIndexChanging ="gridView_PageIndexChanging"
                    BorderWidth="1px" DataKeyNames="id,pcode" OnRowDataBound="gridView_RowDataBound"
                    AutoGenerateColumns="false" PageSize="10"  RowStyle-HorizontalAlign="Center" OnRowCreated="gridView_OnRowCreated" onRowDeleting="gridView_RowDeleting">
                    <Columns>
                    <asp:TemplateField ControlStyle-Width="30" HeaderText="选择"    >
                                <ItemTemplate>
                                    <asp:CheckBox ID="SaleThis" onclick="javascript:CCAB(this);" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField> 
                            
		<%--<asp:BoundField DataField="id" HeaderText="id" SortExpression="id" ItemStyle-HorizontalAlign="Center"  /> --%>
		<asp:BoundField DataField="pcode" HeaderText="货号" SortExpression="pcode" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="pname" HeaderText="名称" SortExpression="pname" ItemStyle-HorizontalAlign="Center"  />
                        <asp:BoundField DataField="pleftcnt" HeaderText="库存量" SortExpression="pleftcnt" ItemStyle-HorizontalAlign="Center"  /> 
                        		<asp:BoundField DataField="pls1" HeaderText="位置" SortExpression="pls1" ItemStyle-HorizontalAlign="Center"  />                             
                            <asp:HyperLinkField HeaderText="详细" ControlStyle-Width="50" DataNavigateUrlFields="id,pcode" DataNavigateUrlFormatString="~/plib/Show.aspx?id0={0}&id1={1}"
                                Text="详细"  /> 
                        <asp:TemplateField ControlStyle-Width="50" HeaderText="操作"   Visible="true"  >
                                <ItemTemplate>
                                     <asp:Button ID="ButtonPlibAdd" tag="pcode" runat="server" Text="添加"  OnClick="btnPlibAdd_Click" >
                    </asp:Button>
                                    <%--<asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Delete"
                                         Text="删除"></asp:LinkButton>--%>
                                </ItemTemplate>
                            </asp:TemplateField>  
                        </Columns>
                </asp:GridView>
               <table border="0" cellpadding="0" cellspacing="1" style="width: 100%;">
                <tr>
                    <td style="width: 1px;">                        
                    </td>
                    <td align="left">
                        <asp:Button ID="btnAdd" runat="server" Text="批量添加" OnClick="btnAddProduct_Click"/>                       
                    </td>
                </tr>
            </table>
            </td>
        </tr>
    </table>
    <br />
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>

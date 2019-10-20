<%@ Page Title="clerk" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="Jium.Web.clerk.List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<script language="javascript" src="/js/CheckBox.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<!--Title -->

            <!--Title end -->

            <!--Add  -->

            <!--Add end -->

            <!--Search -->
            <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>
                    <td style="width: 80px" align="right" class="tdbg">
                         <b>关键字：</b>
                    </td>
                    <td class="tdbg">                       
                    <asp:TextBox ID="txtKeyword" runat="server"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnSearch" runat="server" Text="查询"  OnClick="btnSearch_Click" >
                    </asp:Button>                    
                        
                    </td>
                    <td class="tdbg">
                    </td>
                </tr>
            </table>
            <!--Search end-->
            <br />
            <asp:GridView ID="gridView" runat="server" AllowPaging="True" Width="100%" CellPadding="3"  OnPageIndexChanging ="gridView_PageIndexChanging"
                    BorderWidth="1px" DataKeyNames="id" OnRowDataBound="gridView_RowDataBound"
                    AutoGenerateColumns="false" PageSize="10"  RowStyle-HorizontalAlign="Center" OnRowCreated="gridView_OnRowCreated">
                    <Columns>
                    <asp:TemplateField ControlStyle-Width="30" HeaderText="选择"    >
                                <ItemTemplate>
                                    <asp:CheckBox ID="DeleteThis" onclick="javascript:CCA(this);" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField> 
                            
		<asp:BoundField DataField="cname" HeaderText="cname" SortExpression="cname" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="cphone" HeaderText="cphone" SortExpression="cphone" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="cemail" HeaderText="cemail" SortExpression="cemail" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="csex" HeaderText="csex" SortExpression="csex" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="clevel" HeaderText="clevel" SortExpression="clevel" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ccode" HeaderText="ccode" SortExpression="ccode" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="caddress" HeaderText="caddress" SortExpression="caddress" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="csalesum" HeaderText="csalesum" SortExpression="csalesum" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="cremark" HeaderText="cremark" SortExpression="cremark" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="cls1" HeaderText="cls1" SortExpression="cls1" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="cls2" HeaderText="cls2" SortExpression="cls2" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="cls3" HeaderText="cls3" SortExpression="cls3" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="cls4" HeaderText="cls4" SortExpression="cls4" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="cls5" HeaderText="cls5" SortExpression="cls5" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="cld1" HeaderText="cld1" SortExpression="cld1" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="cld2" HeaderText="cld2" SortExpression="cld2" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="cld3" HeaderText="cld3" SortExpression="cld3" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="cld4" HeaderText="cld4" SortExpression="cld4" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="cld5" HeaderText="cld5" SortExpression="cld5" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="cldc1" HeaderText="cldc1" SortExpression="cldc1" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="cldc2" HeaderText="cldc2" SortExpression="cldc2" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="cldc3" HeaderText="cldc3" SortExpression="cldc3" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="cldc4" HeaderText="cldc4" SortExpression="cldc4" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="cldc5" HeaderText="cldc5" SortExpression="cldc5" ItemStyle-HorizontalAlign="Center"  /> 
                            
                            <asp:HyperLinkField HeaderText="详细" ControlStyle-Width="50" DataNavigateUrlFields="id" DataNavigateUrlFormatString="Show.aspx?id={0}"
                                Text="详细"  />
                            <asp:HyperLinkField HeaderText="编辑" ControlStyle-Width="50" DataNavigateUrlFields="id" DataNavigateUrlFormatString="Modify.aspx?id={0}"
                                Text="编辑"  />
                            <asp:TemplateField ControlStyle-Width="50" HeaderText="删除"   Visible="false"  >
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Delete"
                                         Text="删除"></asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                </asp:GridView>
               <table border="0" cellpadding="0" cellspacing="1" style="width: 100%;">
                <tr>
                    <td style="width: 1px;">                        
                    </td>
                    <td align="left">
                        <asp:Button ID="btnDelete" runat="server" Text="删除" OnClick="btnDelete_Click"/>                       
                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>

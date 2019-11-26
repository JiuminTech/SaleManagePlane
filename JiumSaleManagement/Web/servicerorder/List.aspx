<%@ Page Title="servicerorder" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="Jium.Web.servicerorder.List" %>
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
                            
		<asp:BoundField DataField="ccode" HeaderText="ccode" SortExpression="ccode" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="spid" HeaderText="spid" SortExpression="spid" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="spnum" HeaderText="spnum" SortExpression="spnum" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="spspan" HeaderText="spspan" SortExpression="spspan" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="sostatus" HeaderText="sostatus" SortExpression="sostatus" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="createtime" HeaderText="createtime" SortExpression="createtime" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="updatetime" HeaderText="updatetime" SortExpression="updatetime" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="updateby" HeaderText="updateby" SortExpression="updateby" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="sos1" HeaderText="sos1" SortExpression="sos1" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="sos2" HeaderText="sos2" SortExpression="sos2" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="sos3" HeaderText="sos3" SortExpression="sos3" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="sos4" HeaderText="sos4" SortExpression="sos4" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="sos5" HeaderText="sos5" SortExpression="sos5" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="sod1" HeaderText="sod1" SortExpression="sod1" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="sod2" HeaderText="sod2" SortExpression="sod2" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="sod3" HeaderText="sod3" SortExpression="sod3" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="sod4" HeaderText="sod4" SortExpression="sod4" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="sod5" HeaderText="sod5" SortExpression="sod5" ItemStyle-HorizontalAlign="Center"  /> 
                            
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

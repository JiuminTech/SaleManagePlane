<%@ Page Title="serviceplan" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="Jium.Web.serviceplan.List" %>
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
                            
		<asp:BoundField DataField="id" HeaderText="id" SortExpression="id" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="plandate" HeaderText="plandate" SortExpression="plandate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="plantime" HeaderText="plantime" SortExpression="plantime" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="totalnum" HeaderText="totalnum" SortExpression="totalnum" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="leftnum" HeaderText="leftnum" SortExpression="leftnum" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="nexttotal" HeaderText="nexttotal" SortExpression="nexttotal" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="nextleft" HeaderText="nextleft" SortExpression="nextleft" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="nextid" HeaderText="nextid" SortExpression="nextid" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="pss1" HeaderText="pss1" SortExpression="pss1" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="pss2" HeaderText="pss2" SortExpression="pss2" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="pss3" HeaderText="pss3" SortExpression="pss3" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="pss4" HeaderText="pss4" SortExpression="pss4" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="pss5" HeaderText="pss5" SortExpression="pss5" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="psd1" HeaderText="psd1" SortExpression="psd1" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="psd2" HeaderText="psd2" SortExpression="psd2" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="psd3" HeaderText="psd3" SortExpression="psd3" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="psd4" HeaderText="psd4" SortExpression="psd4" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="psd5" HeaderText="psd5" SortExpression="psd5" ItemStyle-HorizontalAlign="Center"  /> 
                            
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

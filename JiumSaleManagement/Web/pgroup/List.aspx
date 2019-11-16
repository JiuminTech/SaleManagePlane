﻿<%@ Page Title="pgroup" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="Jium.Web.pgroup.List" %>
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
                    <td><asp:LinkButton ID="LinkButtonAdd" runat="server"   Text="新增" PostBackUrl="Add.aspx"></asp:LinkButton>
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
		<asp:BoundField DataField="gid" HeaderText="产品组合ID" SortExpression="gid" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="gindex" HeaderText="内部序号" SortExpression="gindex" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="gpid" HeaderText="子产品ID" SortExpression="gpid" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="gpcnt" HeaderText="子产品数量" SortExpression="gpcnt" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="gdesc" HeaderText="描述" SortExpression="gdesc" ItemStyle-HorizontalAlign="Center"  /> 
		<%--<asp:BoundField DataField="gs1" HeaderText="gs1" SortExpression="gs1" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="gs2" HeaderText="gs2" SortExpression="gs2" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="gs3" HeaderText="gs3" SortExpression="gs3" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="gs4" HeaderText="gs4" SortExpression="gs4" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="gs5" HeaderText="gs5" SortExpression="gs5" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="gd1" HeaderText="gd1" SortExpression="gd1" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="gd2" HeaderText="gd2" SortExpression="gd2" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="gd3" HeaderText="gd3" SortExpression="gd3" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="gd4" HeaderText="gd4" SortExpression="gd4" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="gd5" HeaderText="gd5" SortExpression="gd5" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="gdc1" HeaderText="gdc1" SortExpression="gdc1" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="gdc2" HeaderText="gdc2" SortExpression="gdc2" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="gdc3" HeaderText="gdc3" SortExpression="gdc3" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="gdc4" HeaderText="gdc4" SortExpression="gdc4" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="gdc5" HeaderText="gdc5" SortExpression="gdc5" ItemStyle-HorizontalAlign="Center"  /> --%>
                            
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
                        <asp:Button ID="btnDelete" runat="server" Text="删除" disabled="disabled" OnClick="btnDelete_Click"/>                       
                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>

﻿<%@ Page Title="piorecord" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="Jium.Web.piorecord.List" %>
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
                            
		<asp:BoundField DataField="ptime" HeaderText="ptime" SortExpression="ptime" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="pcode" HeaderText="pcode" SortExpression="pcode" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="pcnt" HeaderText="pcnt" SortExpression="pcnt" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="psaleprice" HeaderText="psaleprice" SortExpression="psaleprice" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="prealprice" HeaderText="prealprice" SortExpression="prealprice" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ptype" HeaderText="ptype" SortExpression="ptype" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="pzekou" HeaderText="pzekou" SortExpression="pzekou" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="premark" HeaderText="premark" SortExpression="premark" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="pguestid" HeaderText="pguestid" SortExpression="pguestid" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="psalerid" HeaderText="psalerid" SortExpression="psalerid" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="pios1" HeaderText="pios1" SortExpression="pios1" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="pios2" HeaderText="pios2" SortExpression="pios2" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="pios3" HeaderText="pios3" SortExpression="pios3" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="pios4" HeaderText="pios4" SortExpression="pios4" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="pios5" HeaderText="pios5" SortExpression="pios5" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="piod1" HeaderText="piod1" SortExpression="piod1" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="piod2" HeaderText="piod2" SortExpression="piod2" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="piod3" HeaderText="piod3" SortExpression="piod3" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="piod5" HeaderText="piod5" SortExpression="piod5" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="piod4" HeaderText="piod4" SortExpression="piod4" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="piodc1" HeaderText="piodc1" SortExpression="piodc1" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="piodc2" HeaderText="piodc2" SortExpression="piodc2" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="piodc3" HeaderText="piodc3" SortExpression="piodc3" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="piodc4" HeaderText="piodc4" SortExpression="piodc4" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="piodc5" HeaderText="piodc5" SortExpression="piodc5" ItemStyle-HorizontalAlign="Center"  /> 
                            
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

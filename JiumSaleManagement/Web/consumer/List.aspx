<%@ Page Title="consumer" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="Jium.Web.consumer.List" %>
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
                            
		<asp:BoundField DataField="cname" HeaderText="姓名" SortExpression="cname" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ccode" HeaderText="顾客ID" SortExpression="ccode" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="cphone" HeaderText="手机号码" SortExpression="cphone" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="cemail" HeaderText="Email" SortExpression="cemail" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="clevel" HeaderText="等级" SortExpression="clevel" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="csum" HeaderText="总消费额" SortExpression="csum" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="csex" HeaderText="性别" SortExpression="csex" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="cremark" HeaderText="备注" SortExpression="cremark" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="css1" HeaderText="更新时间" SortExpression="css1" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="css2" HeaderText="服务工号" SortExpression="css2" ItemStyle-HorizontalAlign="Center"  /> 
		<%--<asp:BoundField DataField="css3" HeaderText="css3" SortExpression="css3" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="css4" HeaderText="css4" SortExpression="css4" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="css5" HeaderText="css5" SortExpression="css5" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="csd1" HeaderText="csd1" SortExpression="csd1" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="csd2" HeaderText="csd2" SortExpression="csd2" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="csd3" HeaderText="csd3" SortExpression="csd3" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="csd4" HeaderText="csd4" SortExpression="csd4" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="csd5" HeaderText="csd5" SortExpression="csd5" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="csdc1" HeaderText="csdc1" SortExpression="csdc1" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="csdc2" HeaderText="csdc2" SortExpression="csdc2" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="csdc3" HeaderText="csdc3" SortExpression="csdc3" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="csdc4" HeaderText="csdc4" SortExpression="csdc4" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="csdc5" HeaderText="csdc5" SortExpression="csdc5" ItemStyle-HorizontalAlign="Center"  /> --%>
                            
                            <%--<asp:HyperLinkField HeaderText="详细" ControlStyle-Width="50" DataNavigateUrlFields="id" DataNavigateUrlFormatString="Show.aspx?id={0}"
                                Text="详细"  />--%>
                        <asp:HyperLinkField HeaderText="消费详细" ControlStyle-Width="50" DataNavigateUrlFields="ccode" DataNavigateUrlFormatString="~/piorecord/List.aspx?id={0}"
                                Text="消费详细"  />
                        <asp:HyperLinkField HeaderText="服务详细" ControlStyle-Width="50" DataNavigateUrlFields="ccode" DataNavigateUrlFormatString="~/consumerservice/List.aspx?id={0}"
                                Text="服务详细"  />
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

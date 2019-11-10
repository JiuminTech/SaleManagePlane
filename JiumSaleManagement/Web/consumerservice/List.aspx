<%@ Page Title="consumerservice" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="Xwsw.Web.NMS.consumerservice.List" %>
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
                            
		<asp:BoundField DataField="ccode" HeaderText="顾客ID" SortExpression="ccode" ItemStyle-HorizontalAlign="Center"  /> 
		<%--<asp:BoundField DataField="cphone" HeaderText="cphone" SortExpression="cphone" ItemStyle-HorizontalAlign="Center"  /> --%>
		<asp:BoundField DataField="cstype" HeaderText="服务类型" SortExpression="cstype" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="csnum" HeaderText="总次数" SortExpression="csnum" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="csleft" HeaderText="剩余次数" SortExpression="csleft" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="csiostatus" HeaderText="状态" SortExpression="csiostatus" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="cstime0" HeaderText="订购日期" SortExpression="cstime0" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="cstime1" HeaderText="第一次" SortExpression="cstime1" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="cstime2" HeaderText="第二次" SortExpression="cstime2" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="cstime3" HeaderText="第三次" SortExpression="cstime3" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="cstime4" HeaderText="第四次" SortExpression="cstime4" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="cstime5" HeaderText="第五次" SortExpression="cstime5" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="cstime6" HeaderText="第六次" SortExpression="cstime6" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="cstime7" HeaderText="第七次" SortExpression="cstime7" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="cstime8" HeaderText="第八次" SortExpression="cstime8" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="cstime9" HeaderText="第九次" SortExpression="cstime9" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="cstime10" HeaderText="第十次" SortExpression="cstime10" ItemStyle-HorizontalAlign="Center"  /> 
		<%--<asp:BoundField DataField="css1" HeaderText="css1" SortExpression="css1" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="css2" HeaderText="css2" SortExpression="css2" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="css3" HeaderText="css3" SortExpression="css3" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="css4" HeaderText="css4" SortExpression="css4" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="css5" HeaderText="css5" SortExpression="css5" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="csd1" HeaderText="csd1" SortExpression="csd1" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="csd2" HeaderText="csd2" SortExpression="csd2" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="csd3" HeaderText="csd3" SortExpression="csd3" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="csd4" HeaderText="csd4" SortExpression="csd4" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="csd5" HeaderText="csd5" SortExpression="csd5" ItemStyle-HorizontalAlign="Center"  /> --%>
                            
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

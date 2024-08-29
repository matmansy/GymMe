<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Customer.Master" AutoEventWireup="true" CodeBehind="OrderSupplementPage.aspx.cs" Inherits="UAP_PSD.Views.OrderSupplementPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="CustomerPage" runat="server">
    <asp:GridView ID="GridView1" AutoGenerateColumns="False" runat="server">
        <Columns>
            <asp:BoundField DataField="SupplementID" HeaderText="ID" SortExpression="SupplementID" />
            <asp:BoundField DataField="SupplementName" HeaderText="Name" SortExpression="SupplementName" />
            <asp:BoundField DataField="SupplementExpiryDate" HeaderText="Expiry Date" SortExpression="SupplementExpiryDate" />
            <asp:BoundField DataField="SupplementPrice" HeaderText="Price" SortExpression="SupplementPrice" />
            <asp:BoundField DataField="MsSupplementType.SupplementTypeName" HeaderText="Type Name" SortExpression="MsSupplementType.SupplementTypeName" />

            <asp:TemplateField HeaderText="Order">
                <ItemTemplate>
                    <asp:Button ID="OrderBtn" runat="server" Text="Order" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="false"> 
        <Columns>
            <asp:BoundField DataField="UserID" HeaderText="User Id" SortExpression="UserID"></asp:BoundField>
            <asp:BoundField DataField="CartID" HeaderText="Cart Id" SortExpression="CartID"></asp:BoundField>
            <asp:BoundField DataField="SuplementID" HeaderText="Supplement id" SortExpression="SuplementID"></asp:BoundField>
            <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity"></asp:BoundField>
        </Columns>
 </asp:GridView>
</asp:Content>

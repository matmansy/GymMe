<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Admin.Master" AutoEventWireup="true" CodeBehind="ManageSupplementPage.aspx.cs" Inherits="UAP_PSD.Views.ManageSupplementPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="AdminPage" runat="server">
    <h2>Manage Supplements</h2>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowDeleting="GridView1_RowDeleting1" OnRowEditing="GridView1_RowEditing">
        <Columns>
            <asp:BoundField DataField="SupplementName" HeaderText="Name" SortExpression="SupplementName" />
            <asp:BoundField DataField="SupplementExpiryDate" HeaderText="Expiry Date" SortExpression="SupplementExpiryDate" />
            <asp:BoundField DataField="SupplementPrice" HeaderText="Price" SortExpression="SupplementPrice" />
            <asp:BoundField DataField="SupplementTypeID" HeaderText="Type ID" SortExpression="SupplementTypeID" />
            <asp:CommandField ButtonType="Button" HeaderText="Update" ShowCancelButton="False" ShowEditButton="True" ShowHeader="True" />
            <asp:CommandField ButtonType="Button" HeaderText="Delete" ShowDeleteButton="True" ShowHeader="True" />
        </Columns>
    </asp:GridView>

</asp:Content>


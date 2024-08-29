<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Customer.Master" AutoEventWireup="true" CodeBehind="CustomerHistoryPage.aspx.cs" Inherits="UAP_PSD.Views.HistoryPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="CustomerPage" runat="server">
    <asp:GridView ID="GridView1" AutoGenerateColumns="False" runat="server">
        <Columns>
            <asp:BoundField DataField="TransactionID" HeaderText="Transaction ID" SortExpression="TransactionID" />
            <asp:BoundField DataField="UserID" HeaderText="User ID" SortExpression="UserID" />
            <asp:BoundField DataField="TransactionDate" HeaderText="Date of Transaction" SortExpression="TransactionDate" />
            <asp:BoundField DataField="Status" HeaderText="Transaction Status" SortExpression="Status" />
            <asp:TemplateField HeaderText="Detail">
                <ItemTemplate>
                    <asp:Button ID="viewDetailBtn" runat="server" Text="View" />o
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>

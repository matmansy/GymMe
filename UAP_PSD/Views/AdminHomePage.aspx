<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Admin.Master" AutoEventWireup="true" CodeBehind="AdminHomePage.aspx.cs" Inherits="UAP_PSD.Views.AdminHomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="AdminPage" runat="server">
    <div>
        <asp:GridView ID="GridView1" AutoGenerateColumns="False" runat="server">
            <Columns>
                <asp:BoundField DataField="UserName" HeaderText="Name" SortExpression="UserName" />
                <asp:BoundField DataField="UserEmail" HeaderText="Email" SortExpression="UserEmail" />
                <asp:BoundField DataField="UserDOB" HeaderText="Date of Birth" SortExpression="UserDOB" />
                <asp:BoundField DataField="UserGender" HeaderText="Gender" SortExpression="UserGender" />
                <asp:BoundField DataField="UserRole" HeaderText="Role" SortExpression="UserRole" />
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>

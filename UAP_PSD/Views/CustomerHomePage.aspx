<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Customer.Master" AutoEventWireup="true" CodeBehind="CustomerHomePage.aspx.cs" Inherits="UAP_PSD.Views.CustomerHomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="CustomerPage" runat="server">
    <h1>
        Welcome
    </h1>

    <div>
        <strong>Role: </strong>
        <asp:Label ID="RoleLbl" runat="server" Text ="Customer"></asp:Label>
    </div>
</asp:Content>

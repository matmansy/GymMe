<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Admin.Master" AutoEventWireup="true" CodeBehind="UpdateSupplementPage.aspx.cs" Inherits="UAP_PSD.Views.UpdateSupplementPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="AdminPage" runat="server">
        <h2>Update Supplement</h2>
<div>
    <asp:Button ID="BackBtn" runat="server" Text="Back" OnClick="BackBtn_Click"/>
</div>

<div>
    <asp:Label ID="NameLbl" runat="server" Text="Name"></asp:Label>
    <asp:TextBox ID="NameTxt" runat="server"></asp:TextBox>
</div>

<div>
    <asp:Label ID="ExpiryDateLbl" runat="server" Text="Expiry Date"></asp:Label>
    <asp:TextBox ID="ExpiryDateTxt" runat="server" TextMode="Date"></asp:TextBox>
</div>

<div>
    <asp:Label ID="PriceLbl" runat="server" Text="Price"></asp:Label>
    <asp:TextBox ID="PriceTxt" runat="server"></asp:TextBox>
</div>

<div>
    <asp:Label ID="TypeLbl" runat="server" Text="Type"></asp:Label>
    <asp:TextBox ID="TypeTxt" runat="server"></asp:TextBox>
</div>

<div>
    <asp:Label ID="ErrorLbl" runat="server" ></asp:Label>
</div>
    
<div>
    <asp:Button ID="UpdateBtn" runat="server" Text="Update" OnClick="UpdateBtn_Click"/>
</div>
</asp:Content>

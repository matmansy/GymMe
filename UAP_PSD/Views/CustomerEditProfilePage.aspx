<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Customer.Master" AutoEventWireup="true" CodeBehind="CustomerEditProfilePage.aspx.cs" Inherits="UAP_PSD.Views.CustomerEditProfilePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="CustomerPage" runat="server">
        <h1>Profile</h1>
        <div>
            <asp:Label ID="UserNameLbl" runat="server" Text="Username"></asp:Label>
            <asp:TextBox ID="UserNameTxt" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="UserEmailLbl" runat="server" Text="Email"></asp:Label>
            <asp:TextBox ID="UserEmailTxt" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="UserGenderLbl" runat="server" Text="Gender"></asp:Label>
            <asp:RadioButtonList ID="UserGenderRbl" runat="server">
                <asp:ListItem>Male</asp:ListItem>
                <asp:ListItem>Female</asp:ListItem>
            </asp:RadioButtonList>
        </div>
        <div>
            <asp:Label ID="UserDOBLbl" runat="server" Text="Date of birth"></asp:Label>
            <asp:Calendar ID="CalendarDOB" runat="server"></asp:Calendar>
        </div>
        <div>
            <asp:Button ID="Button1" runat="server" Text="Update Profile" />
        </div>
</asp:Content>

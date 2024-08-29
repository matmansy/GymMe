<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Customer.Master" AutoEventWireup="true" CodeBehind="CustomerProfilePage.aspx.cs" Inherits="UAP_PSD.Views.CustomerProfilePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="CustomerPage" runat="server">
    <h1>Profile</h1>
    <div>
        <strong>Name: </strong>
        <asp:Label ID="UserNameLbl" runat="server" Text=""></asp:Label>
    </div>
    <div>
        <strong>Email: </strong>
        <asp:Label ID="UserEmailLbl" runat="server" Text=""></asp:Label>
    </div>
    <div>
        <strong>Gender: </strong>
        <asp:Label ID="UserGenderLbl" runat="server" Text=""></asp:Label>
    </div>
    <div>
        <strong>DOB: </strong>
        <asp:Label ID="UserDOBLbl" runat="server" Text=""></asp:Label>
    </div>

    <br />
    <h2>Edit Profile</h2>
    <div>
    <asp:Label ID="Label1" runat="server" Text="Username: "></asp:Label>
    <asp:TextBox ID="UserNameTxt" runat="server"></asp:TextBox>
</div>
<div>
    <asp:Label ID="Label2" runat="server" Text="Email: "></asp:Label>
    <asp:TextBox ID="UserEmailTxt" runat="server"></asp:TextBox>
</div>
<div>
    <asp:Label ID="Label3" runat="server" Text="Gender: "></asp:Label>
    <asp:RadioButtonList ID="UserGenderRbl" runat="server">
        <asp:ListItem>Male</asp:ListItem>
        <asp:ListItem>Female</asp:ListItem>
    </asp:RadioButtonList>
</div>
<div>
    <asp:Label ID="Label4" runat="server" Text="Date of birth"></asp:Label>
    <asp:Calendar ID="CalendarDOB" runat="server"></asp:Calendar>
</div>
    <div>
        <asp:Button ID="UpdateProfileBtn" runat="server" Text="Update Profile" />
    </div>
    <br />
    <h2>Change Password</h2>
    <div>
        <asp:Label ID="Label5" runat="server" Text="Old Password: "></asp:Label>
        <asp:TextBox ID="oldpasswordtxt" runat="server" TextMode="Password"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="Label6" runat="server" Text="New Password: "></asp:Label>
        <asp:TextBox ID="newpasswordtxt" runat="server" TextMode="Password"></asp:TextBox>
    </div>
    <div>
        <asp:Button ID="UpdatePassBtn" runat="server" Text="Update Password" />
    </div>
</asp:Content>

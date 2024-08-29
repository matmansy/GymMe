<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="UAP_PSD.Views.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>GymMe - Login</title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Login</h1>
        <div>
            <asp:Label ID="UsernameLbl" runat="server" Text="Username :"></asp:Label>
            <asp:TextBox ID="usernametxt" runat="server"></asp:TextBox>
        </div>
         <div>
            <asp:Label ID="LabelPassword" runat="server" Text="Password :"></asp:Label>
            <asp:TextBox ID="passwordtxt" runat="server" TextMode="Password"></asp:TextBox>
        </div>
        <div>
            <asp:CheckBox ID="RememberMeCheckBox" runat="server" Text="Remember me" />
        </div>
        <div>
            <asp:Label ID="ErrorLbl" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <asp:Button ID="LoginBtn" runat="server" Text="Login" OnClick="ButtonLogin_Click" />
        </div>
        <br />
        <div class="sign-up">
            <asp:Label ID="dont_have_accountLbl" runat="server" Text="Don't have an account?"></asp:Label>
            <asp:LinkButton ID="dont_have_accountLb" runat="server" OnClick="dont_have_accountLb_Click">Sign Up!</asp:LinkButton>
        </div>
    </form>
</body>
</html>
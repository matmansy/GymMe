<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="UAP_PSD.Views.RegisterPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register Page</title>
</head>
<body>
    <form id="form1" runat="server">
       <div>
            <h1>Gym Me Register</h1>
        </div>
        <div>
            <asp:Label ID="LabelRegUsername" runat="server" Text="Username :"></asp:Label>
            <asp:TextBox ID="Usernametxt" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="LabelRegEmail" runat="server" Text="Email :"></asp:Label>
            <asp:TextBox ID="Emailtxt" runat="server"></asp:TextBox>
        </div>
         <div>
            <asp:Label ID="LabelRegGender" runat="server" Text="Gender :"></asp:Label>
             
             <asp:RadioButtonList ID="RadioButtonListGender" runat="server">
                 <asp:ListItem Value="Male">Male</asp:ListItem>
                 <asp:ListItem Value="Female">Female</asp:ListItem>
             </asp:RadioButtonList>
        </div>
        <div>
            <asp:Label ID="LabelRegPassword" runat="server" Text="Password :"></asp:Label>
            <asp:TextBox ID="Passwordtxt" runat="server" TextMode="Password"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="LabelRegConfPassword" runat="server" Text="Confirm Password :"></asp:Label>
            <asp:TextBox ID="ConfPasswordtxt" runat="server" TextMode="Password"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="LabelRegDOB" runat="server" Text="Date Of Birth :"></asp:Label>
            <asp:TextBox ID="DOBtxt" runat="server" TextMode="Date"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="RegisterErrorLbl" runat="server" Text="" ForeColor="Red"></asp:Label>
        </div>
        <div>
            <asp:Button ID="RegisterBtn" runat="server" Text="Register" OnClick="ButtonRegister_Click" />
        </div>
        <br />
        <div>
            <asp:Label ID="Label1" runat="server" Text="Have an account? Sign in!"></asp:Label>
        </div>
        <div>
            <asp:LinkButton ID="LoginRedirectLinkBtn" runat="server" OnClick="LoginRedirectLinkBtn_Click">Login</asp:LinkButton>
        </div>
    </form>
</body>
</html>

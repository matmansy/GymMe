using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UAP_PSD.Controller;
using UAP_PSD.Handlers;

namespace UAP_PSD.Views
{
    public partial class RegisterPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void ButtonRegister_Click(object sender, EventArgs e)
        {
            string username = Usernametxt.Text;
            string email = Emailtxt.Text;
            string gender = RadioButtonListGender.SelectedItem?.Text;
            string password = Passwordtxt.Text;
            string confirmPassword = ConfPasswordtxt.Text;
            string dob = DOBtxt.Text;

            string result = RegisterController.Register(username, email, dob, gender, password, confirmPassword);

            if (result.Equals("Success"))
            {
                string registerResult = MsUserHandler.DoRegister(username, email, dob, gender, password, confirmPassword);

                if (registerResult.Equals("Success"))
                {
                    Response.Redirect("/Views/LoginPage.aspx");
                }
                else
                {
                    RegisterErrorLbl.Text = registerResult;
                }
            }
            else
            {
                RegisterErrorLbl.Text = result;
            }
        }

        protected void LoginRedirectLinkBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/LoginPage.aspx");
        }
    }
}
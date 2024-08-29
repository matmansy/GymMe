using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UAP_PSD.Controller;
using UAP_PSD.Models;
using UAP_PSD.Repositories;


namespace UAP_PSD.Views
{
    public partial class LoginPage : System.Web.UI.Page 
    {
        private static DatabaseEntities1 db = new DatabaseEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            ErrorLbl.ForeColor = System.Drawing.Color.Red;
        }

        protected void ButtonLogin_Click(object sender, EventArgs e)
        {
            String username = usernametxt.Text;
            String password = passwordtxt.Text;
            bool rememberCheck = RememberMeCheckBox.Checked;

            ErrorLbl.Text = LoginController.DoLogin(username, password);
                ErrorLbl.ForeColor = System.Drawing.Color.Red;
            var user = (from x in db.MsUsers where x.UserName.Equals(username) && x.UserPassword.Equals(password) select x).FirstOrDefault();
            if (user != null)
            {
                Session["UserID"] = user.UserID;

                if (user.UserRole == "Admin")
                {
                    Response.Redirect("/Views/HomePage.aspx");
                }
                else
                {
                    Response.Redirect("/Views/HomePageCustomer.aspx");
                }

                if (rememberCheck)
                {
                    HttpCookie cookie = new HttpCookie("user-cookie");
                    cookie.Value = user.UserID.ToString();
                    if (rememberCheck)
                    {
                        cookie.Expires = DateTime.Now.AddHours(1);
                    }
                    else
                    {
                        cookie.Expires = DateTime.MinValue;
                    }
                    Response.Cookies.Add(cookie);
                }
            }
        }

        protected void dont_have_accountLb_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Views/RegisterPage.aspx");
        }
    }
}
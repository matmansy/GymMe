using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UAP_PSD.Models;

namespace UAP_PSD.Views
{
    public partial class CustomerProfilePage : System.Web.UI.Page
    {
        private static DatabaseEntities1 db = new DatabaseEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["UserID"] != null)
                {
                    int userID = (int)Session["UserID"];
                    LoadUserProfile(userID);
                }
            }
        }

        private void LoadUserProfile(int userID)
        {
            var user = (from x in db.MsUsers where x.UserID == userID select x).FirstOrDefault();

            if (user != null)
            {
                UserNameLbl.Text = user.UserName;
                UserEmailLbl.Text = user.UserEmail;
                UserGenderLbl.Text = user.UserGender;
                UserDOBLbl.Text = user.UserDOB.ToString("dd-MM-yyyy");
            }
        }
    }
}
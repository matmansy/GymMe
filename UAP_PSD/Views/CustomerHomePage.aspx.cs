using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UAP_PSD.Models;
using UAP_PSD.Repositories;

namespace UAP_PSD.Views
{
    public partial class CustomerHomePage : System.Web.UI.Page
    {
        private static DatabaseEntities1 db = new DatabaseEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["UserID"] != null)
                {
                    int userID = (int)Session["UserID"];
                    LoadUserRole(userID);
                }
            }
        }

        protected void LoadUserRole(int userId) 
        { 
            var user = (from x in db.MsUsers where x.UserID == userId select x).FirstOrDefault();

            if (user != null)
            {
                RoleLbl.Text = user.UserRole;
            }
        }
    }
}
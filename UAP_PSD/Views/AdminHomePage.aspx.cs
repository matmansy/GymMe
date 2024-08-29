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
    public partial class AdminHomePage : System.Web.UI.Page
    {
        private static DatabaseEntities1 db = new DatabaseEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            var user = MsUserRepository.GetCustomers();

            GridView1.DataSource = user;
            GridView1.DataBind();
        }
    }
}
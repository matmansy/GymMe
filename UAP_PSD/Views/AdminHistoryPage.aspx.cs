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
    public partial class AdminHistoryPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int userID = Convert.ToInt32(Session["UserID"]);
            List<MsCart> userCarts = MsCartRepository.CallCart(userID);
            GridView1.DataSource = userCarts;
            GridView1.DataBind();
        }
    }
}
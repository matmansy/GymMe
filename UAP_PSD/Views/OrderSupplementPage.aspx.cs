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
    public partial class OrderSupplementPage : System.Web.UI.Page
    {
        DatabaseEntities1 db = new DatabaseEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            var supplements = MsSupplementRepository.GetSupplement();
                GridView1.DataSource = supplements;
                GridView1.DataBind();


                int userID = Convert.ToInt32(Session["UserID"]);
                List<MsCart> userCarts = MsCartRepository.CallCart(userID);
                GridView2.DataSource = userCarts;
                GridView2.DataBind();
        }

    }
}
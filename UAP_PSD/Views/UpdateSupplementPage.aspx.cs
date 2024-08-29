using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UAP_PSD.Controller;

namespace UAP_PSD.Views
{
    public partial class UpdateSupplementPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void UpdateBtn_Click(object sender, EventArgs e)
        {
            int id;
            String name = NameTxt.Text;
            String expiryDate = Convert.ToDateTime(ExpiryDateTxt.Text);
            int price = Convert.ToInt32(PriceTxt.Text);
            int type = Convert.ToInt32(TypeTxt.Text);
            ManageSupplementController.UpdateSupplement(id, name, expiryDate, price, type);
        }

        protected void BackBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/ManageSupplementPage.aspx");
        }
    }
}
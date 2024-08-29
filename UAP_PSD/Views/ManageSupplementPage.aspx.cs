using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UAP_PSD.Controller;
using UAP_PSD.Repositories;

namespace UAP_PSD.Views
{
    public partial class ManageSupplementPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var supplements = MsSupplementRepository.GetSupplement();
            GridView1.DataSource = supplements;
            GridView1.DataBind();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
          GridViewRow Row = GridView1.Rows[e.NewEditIndex];
          String ID = Row.Cells[0].Text.ToString();

          Response.Redirect("/Page/UpdateSupplementPage.aspx?ID=" + ID);
        }

        protected void GridView1_RowDeleting1(object sender, GridViewDeleteEventArgs e)
        {
          GridViewRow Row = GridView1.Rows[e.RowIndex];
          int id = Convert.ToInt32(Row.Cells[0].Text.ToString());

         ManageSupplementController.DeleteSupplement(id);
         GridView1.DataBind();

         Response.Redirect("/Page/ManageSupplementPage.aspx");
        }
    }
}
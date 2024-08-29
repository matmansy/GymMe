using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UAP_PSD.Controller;
using UAP_PSD.Models;
using UAP_PSD.Repositories;

namespace UAP_PSD.Views
{
    public partial class OrderQueuePage : System.Web.UI.Page
    {
        private static DatabaseEntities1 db = new DatabaseEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadTransactions();
            }
        }

        private void LoadTransactions()
        {
            var transactions = TransactionHeaderRepository.GetAllTransactionHeaders();
            GridView.DataSource = transactions;
            GridView.DataBind();
        }

        protected void GridView_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "UpdateStatus")
            {
                int transactionId = Convert.ToInt32(e.CommandArgument);
                TransactionHeaderController.UpdateTransactionStatus(transactionId, "Handled");
                LoadTransactions();
            }
        }
    }
}
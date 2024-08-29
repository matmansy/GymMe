using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.History;
using System.Linq;
using System.Web;
using UAP_PSD.Models;

namespace UAP_PSD.Repositories
{
    public class TransactionDetailRepository
    {
        

        public static void AddTransactionDetail(List<TransactionDetail> td)
        {
            DatabaseEntities1 db = DatabaseSingleton.GetInstance();
            db.TransactionDetails.AddRange(td);
            db.SaveChanges();
        }

        //public static List<TransactionDetail> GetTransactionDetails(int transactionId)
        
             //DatabaseEntities1 db = DatabaseSingleton.GetInstance();
             //return (from x in db.TransactionDetails where history => history.TransactionID == transactionId).ToList();
        
    }
}
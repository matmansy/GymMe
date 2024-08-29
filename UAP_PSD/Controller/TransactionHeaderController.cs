using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UAP_PSD.Handlers;

namespace UAP_PSD.Controller
{
    public class TransactionHeaderController
    {
        public static void UpdateTransactionStatus(int transactionId, string status)
        {
            TransactionHeaderHandler.UpdateStatus(transactionId, status);
        }
    }
}
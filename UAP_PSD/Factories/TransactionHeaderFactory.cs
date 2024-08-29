using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UAP_PSD.Models;

namespace UAP_PSD.Factories
{
    public class TransactionHeaderFactory
    {
        public static TransactionHeader Create(int UserID)
        {
            TransactionHeader newTransactionHeader = new TransactionHeader
            {
                UserID = UserID,
                TransactionDate = DateTime.Now,
                Status = "Unhandled"
            };
            return newTransactionHeader;
        }
    }
}
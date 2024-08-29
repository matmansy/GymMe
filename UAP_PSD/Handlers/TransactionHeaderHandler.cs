using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UAP_PSD.Repositories;

namespace UAP_PSD.Handlers
{
    public class TransactionHeaderHandler
    {
        public static void UpdateStatus(int ID, string status)
        {
            TransactionHeaderRepository.UpdateStatus(ID, status);
        }
    }
}
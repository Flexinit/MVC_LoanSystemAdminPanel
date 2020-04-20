using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoanSystemAdminPanel.Models
{
    public class LoanRepayment
    {
        public int ID { get; set; }
        public string IMEI { get; set; }
        public string AmountRepaid { get; set; }
        public string AmountRemaining { get; set; }
        public string DateOfRepayment { get; set; }
        public string TransactnID { get; set; }
       
    }
}
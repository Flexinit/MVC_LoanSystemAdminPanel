using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LoanSystemAdminPanel.Models

{
    public class RepaymentMpesaTrans
    {
        public int ID { get; set; }

        [Editable(false)]
        [Display(Name = "Device IMEI")]
        public string DeviceIMEI { get; set; }

        [Editable(false)]
        [Display(Name = "Transaction ID")]
        public string TransactionID { get; set; }

        [Editable(false)]
        [Display(Name = "Amount")]
        public string Amount { get; set; }

        [Editable(false)]
        [Display(Name = "Mpesa Receipt No.")]
        public string MpesaReceiptNumber { get; set; }

        [Editable(false)]
        [Display(Name = "Transaction Date")]
        public string TransactionDate { get; set; }

        [Editable(false)]
        [Display(Name = "Phone No.")]
        public string PhoneNumber { get; set; }
       
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LoanSystemAdminPanel.Models
{
    public class SuccessfulLoanApplications
    {

        public int ID { get; set; }

        [Display(Name = "Device IMEI")]
        public string DeviceIMEI { get; set; }

        [Display(Name = "Amount")]
        public long Amount { get; set; }

        [Display(Name = "Interest")]
        public string Interest { get; set; }

        [Display(Name = "Disbursed?")]
        public bool Disbursed { get; set; }

        [Display(Name = "Date of Application")]
        public string DateOfLoanApplication { get; set; }

        [Display(Name = "Number of Days")]
        public string PeriodOfDays { get; set; }
    }
}
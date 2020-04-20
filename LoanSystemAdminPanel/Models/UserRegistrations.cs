using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LoanSystemAdminPanel.Models
{
    public class UserRegistrations
    {

        public int ID { get; set; }

        [Display(Name = "First Name")]
        public string firstName { get; set; }

        [Display(Name = "Last Name")]
        public string lastName { get; set; }

        [Display(Name = "Device IMEI")]
        public string deviceIMEI { get; set; }

        [Display(Name = "Phone Number")]
        public string phoneN { get; set; }

        [Display(Name = "ID Number")]
        public string IDnumber { get; set; }

        [Display(Name = "Date of Birth")]
        public DateTime  dateOfBirth { get; set; }

        [Display(Name = "Email Address")]
        public string emailAddress { get; set; }

        [Display(Name = "Gender")]
        public string gender { get; set; }

        [Display(Name = "Phone Is Mine")]
        public bool phoneIsMine { get; set; }
        
         [Display(Name = "Phone Is New")]
        public bool phoneIsNew { get; set; }

        [Display(Name = "How Long Have used Phone")]
        public string howLongHaveUsedPhone { get; set; }

        [Display(Name = "Average Income")]
        public string averageIncome { get; set; }

        [Display(Name = "I have a Job")]
        public bool haveAjob { get; set; }

        [Display(Name = "Self Employed")]
        public bool selfEmployed { get; set; }

        [Display(Name = "Student")]
        public bool student { get; set; }

        [Display(Name = "No Income")]
        public bool haveNoIncome { get; set; }

        [Display(Name = "Purpose of Loan")]
        public string purposeOfLoan { get; set; }

        [Display(Name = "Kind of Expense for Loan")]
        public string kindOfExpenseForLoan { get; set; }

        [Display(Name = "Description of Expense for Loan")]
        public string descriptionForPurposeOfLoan { get; set; }
        //public string descriptionForMainSourceOfIncome { get; set; }
        //public string dateOfStartingJob { get; set; }
        //public string latestHouseholdIncome { get; set; }

        [Display(Name = "Any Outstanding Loan?")]
        public bool anyOutstandingLoan { get; set; }

    }
       
}
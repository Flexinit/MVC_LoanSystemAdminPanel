using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LoanSystemAdminPanel.Models
{
    public class LoanUserManagement
    {
       
        public int ID { get; set; }


        [Display(Name = "Username")]
        public string username { get; set; }
        public string password { get; set; }
    }
}
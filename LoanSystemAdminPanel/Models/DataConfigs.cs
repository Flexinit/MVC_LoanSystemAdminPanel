using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;


namespace LoanSystemAdminPanel.Models
{
    public static class DataConfigs
    {
        public static string MailFromAddress = ConfigurationManager.AppSettings["MailFromAddress"];
        public static string MailUserName = ConfigurationManager.AppSettings["MailUsername"];
        public static string MailDisplayName = ConfigurationManager.AppSettings["MailDisplayName"];
        public static string MailPassword = ConfigurationManager.AppSettings["MailPassword"];
        public static string MailServer = ConfigurationManager.AppSettings["MailServer"];
        public static string MailPort = ConfigurationManager.AppSettings["MailPort"];
    }
}
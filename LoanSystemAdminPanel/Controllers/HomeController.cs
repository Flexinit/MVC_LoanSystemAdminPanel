using LoanSystemAdminPanel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoanSystemAdminPanel.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            GetLoanTally();


            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public  void GetLoanTally() {
            var context = new ApplicationDbContext();

            //Get total number of Registrants
            var query = from Registrants in context.Registrations
                        select Registrants.ID;

            string registrants = query.Count().ToString();

            //Get total number of Loan Applications
            var loanApplication = from SuccessfulLoanApplications in context.SuccessfulLoanApplications
                        select SuccessfulLoanApplications.ID;

            string totalLoanApplcs = loanApplication.Count().ToString();


            //Get total number of Mpesa Transactions
            var mpesaTransactns = from RepaymentMpesaTrans in context.RepaymentMpesaTrans
                                  select RepaymentMpesaTrans.ID;

            string totalMpesaTrans = mpesaTransactns.Count().ToString();


            //Get total amount of Money Lent out
            string total;
            var totalAmount = context.SuccessfulLoanApplications.GroupBy(o => o.Disbursed)
                  .Select(g => new { membername = g.Key, total = g.Sum(i => i.Amount) });

            foreach (var group in totalAmount)
            {
                Console.WriteLine("Membername = {0} Totalcost={1}", group.membername, group.total);
                ViewBag.TotalAmount = group.total.ToString();
            }

            ViewBag.Registrants = registrants;
            ViewBag.TotalLoanApplcs = totalLoanApplcs;
            ViewBag.TotalMpesaTrans = totalMpesaTrans;
            


        }

    }
}
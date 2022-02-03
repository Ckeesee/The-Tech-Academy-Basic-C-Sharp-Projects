using CarInsurance.Models;
using CarInsurance.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsurance.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Admin()
        {
            using (InsuranceEntities db = new InsuranceEntities())
            {
                //var signups = db.SignUps.Where(x => x.Removed == null).ToList();
                var insuree = db.Insurees;
                var insureeVms = new List<InsureeVm>();
                foreach (var client in insuree)
                {
                    var insureeVm = new InsureeVm();
                    insureeVm.Id = client.Id;
                    insureeVm.FirstName = client.FirstName;
                    insureeVm.LastName = client.LastName;
                    insureeVm.EmailAddress = client.EmailAddress;
                    insureeVm.Quote = client.Quote;
                    insureeVms.Add(insureeVm);
                }
                return View(insureeVms);
            }
           
        }
    }
}
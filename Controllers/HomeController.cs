using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace phi_portal.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "ТОВАРИСТВА З ОБМЕЖЕНОЮ ВІДПОВІДАЛЬНІСТЮ \"ПРОДХІМІНДУСТРІЯ\"";

            return View();
        }

        public ActionResult ZvitAudit()
        {
            return View();
        }

        public ActionResult ZvitUpr()
        {
            return View();
        }

        public ActionResult FinZvit()
        {
            return View();
        }

        public ActionResult ZvitAudit2020()
        {
            return View();
        }

        public ActionResult ZvitUpr2020()
        {
            return View();
        }

        public ActionResult FinZvit2020()
        {
            return View();
        }

        public ActionResult ZvitAudit2021()
        {
            return View();
        }

        public ActionResult ZvitUpr2021()
        {
            return View();
        }

        public ActionResult FinZvit2021()
        {
            return View();
        }

        public ActionResult ZvitAudit2022()
        {
            return View();
        }

        public ActionResult ZvitUpr2022()
        {
            return View();
        }

        public ActionResult FinZvit2022()
        {
            return View();
        }
    }
}
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
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SEE.Controllers
{
    public class UserController : Controller
    {
        public string Message { get; set; }

        public ActionResult Index()
        {
            ViewBag.Message = Message;
            return View();
        }

    }
}

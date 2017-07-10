using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace YECBBS.Controllers
{
    public class UserController : Controller
    {
        //
        // GET: /User/

        public ActionResult Index()
        {
            return View();
        }

		public PartialViewResult Login()
		{
			return PartialView();
		}

		public PartialViewResult Set()
		{
			return PartialView();
		}

    }
}

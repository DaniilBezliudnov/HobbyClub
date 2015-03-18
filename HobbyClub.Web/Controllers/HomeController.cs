using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HobbyClub.Web.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Main()
		{
			return View();
		}

        public ActionResult Home()
        {
            return View();
        }

        public ActionResult Groups()
        {
            return View();
        }

        public ActionResult Events()
        {
            return View();
        }


        public ActionResult Interests()
        {
            return View();
        }

        //public ActionResult About()
        //{
        //    return View();
        //}

        
	}
}
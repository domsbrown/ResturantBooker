using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ResturantBooker.Models;

namespace ResturantBooker.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View( new RestaurantBooking());
        }

		[HttpPost]
		public ActionResult Index(RestaurantBooking model)
		{
			// post, redirect, get pattern

			if (ModelState.IsValid)
			{
				//do some processing here
				return RedirectToAction("Index");
			}
				return View(model);
		}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ResturantBooker.DataAccess;
using ResturantBooker.Models;
using ResturantBooker.Models.ViewModels;

namespace ResturantBooker.Controllers
{
	public class AdminController : Controller
	{
		//
		// GET: /Admin/

		public ActionResult Index(int page = 1, int pageSize = 10)
		{
			ViewBag.Message = "Meals";
			var context = new RestaurantDataContext();
			var viewmodel = new AdminMealsViewModel(page, pageSize);
			viewmodel.RecordCount = context.Meal1s.Count();
			viewmodel.Meals = context.Meal1s.Skip(viewmodel.GetSkipCount()).Take(viewmodel.GetTakeCount()).ToList();
			return View(viewmodel);
		}

		[HttpPost]
		public ActionResult Index(Admin model)
		{
			if (ModelState.IsValid)
			{
				return RedirectToAction("Index");
			}
			return View("Index");
		}

		public ActionResult AdminBreads(int page = 1, int pageSize = 10)
		{
			ViewBag.Message = "Breads";
			var context = new RestaurantDataContext();
			var viewmodel = new AdminBreadsViewModel(page, pageSize);
			viewmodel.RecordCount = context.Breads.Count();
			viewmodel.Loafs = context.Breads.Skip(viewmodel.GetSkipCount()).Take(viewmodel.GetTakeCount()).ToList();
			return View(viewmodel);
		}

		[HttpPost]
		public ActionResult AdminBreads(Admin model)
		{
			if (ModelState.IsValid)
			{
				return RedirectToAction("Index");
			}
			return View("Index");
		}

		public ActionResult AdminDrinks(int page = 1, int pageSize = 10)
		{
			ViewBag.Message = "Drinks";
			var context = new RestaurantDataContext();
			var viewmodel = new AdminDrinksViewModel(page, pageSize);
			viewmodel.RecordCount = context.Drinks.Count();
			viewmodel.Drinks = context.Drinks.Skip(viewmodel.GetSkipCount()).Take(viewmodel.GetTakeCount()).ToList();
			return View(viewmodel);
		}

		[HttpPost]
		public ActionResult AdminDrinks(Admin model)
		{
			if (ModelState.IsValid)
			{
				return RedirectToAction("Index");
			}
			return View("Index");
		}

		public ActionResult AdminCondiments(int page = 1, int pageSize = 10)
		{
			ViewBag.Message = "Condiments";
			var context = new RestaurantDataContext();
			var viewmodel = new AdminCondimentsViewModel(page, pageSize);
			viewmodel.RecordCount = context.Condiments.Count();
			viewmodel.Condiments = context.Condiments.Skip(viewmodel.GetSkipCount()).Take(viewmodel.GetTakeCount()).ToList();
			return View(viewmodel);
		}

		[HttpPost]
		public ActionResult AdminCondiments(Admin model)
		{
			if (ModelState.IsValid)
			{
				return RedirectToAction("Index");
			}
			return View("Index");
		}
		
		public ActionResult AdminExtras(int page = 1, int pageSize = 10)
		{
			ViewBag.Message = "Extras";
			var context = new RestaurantDataContext();
			var viewmodel = new AdminExtrasViewModel(page, pageSize);
			viewmodel.RecordCount = context.Extras.Count();
			viewmodel.Extras = context.Extras.Skip(viewmodel.GetSkipCount()).Take(viewmodel.GetTakeCount()).ToList();
			return View(viewmodel);
		}

		[HttpPost]
		public ActionResult AdminExtras(Admin model)
		{
			if (ModelState.IsValid)
			{
				return RedirectToAction("Index");
			}
			return View("Index");
		}

		public ActionResult AdminFillings(int page = 1, int pageSize = 10)
		{
			ViewBag.Message = "Fillings";
			var context = new RestaurantDataContext();
			var viewmodel = new AdminFillingsViewModel(page, pageSize);
			viewmodel.RecordCount = context.Fillings.Count();
			viewmodel.Fillings = context.Fillings.Skip(viewmodel.GetSkipCount()).Take(viewmodel.GetTakeCount()).ToList();
			return View(viewmodel);
		}

		[HttpPost]
		public ActionResult AdminFillings(Admin model)
		{
			if (ModelState.IsValid)
			{
				return RedirectToAction("Index");
			}
			return View("Index");
		}

		public ActionResult AdminSideDishes(int page = 1, int pageSize = 10)
		{
			ViewBag.Message = "Side Dishes";
			var context = new RestaurantDataContext();
			var viewmodel = new AdminSideDishesViewModel(page, pageSize);
			viewmodel.RecordCount = context.SideDishes.Count();
			viewmodel.SideDishes = context.SideDishes.Skip(viewmodel.GetSkipCount()).Take(viewmodel.GetTakeCount()).ToList();
			return View(viewmodel);
		}

		[HttpPost]
		public ActionResult AdminSideDishes(Admin model)
		{
			if (ModelState.IsValid)
			{
				return RedirectToAction("Index");
			}
			return View("Index");
		}

		public ActionResult AdminSnacks(int page = 1, int pageSize = 10)
		{
			ViewBag.Message = "Snacks";
			var context = new RestaurantDataContext();
			var viewmodel = new AdminSnacksViewModel(page, pageSize);
			viewmodel.RecordCount = context.Snacks.Count();
			viewmodel.Snacks = context.Snacks.Skip(viewmodel.GetSkipCount()).Take(viewmodel.GetTakeCount()).ToList();
			return View(viewmodel);
		}

		[HttpPost]
		public ActionResult AdminSnacks(Admin model)
		{
			if (ModelState.IsValid)
			{
				return RedirectToAction("Index");
			}
			return View("Index");
		}
	}
}

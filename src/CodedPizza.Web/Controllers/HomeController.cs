using CodedPizza.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodedPizza.Web.Controllers
{
	public class HomeController : Controller
	{

		public HomeController()
		{
			CodedPizzaContext = new CodedPizzaContext();
		}

		public CodedPizzaContext CodedPizzaContext { get; private set; }

		public ActionResult Index()
		{
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


		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
			if (disposing)
			{
				CodedPizzaContext.Dispose();
			}
		}
	}
}
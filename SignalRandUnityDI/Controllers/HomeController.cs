using SignalRandUnityDI.Models;
using System.Web.Mvc;

namespace SignalRandUnityDI.Controllers
{
	public class HomeController : Controller
	{
		private IIndexViewModel _indexViewModel;

		public HomeController(IIndexViewModel indexViewModel)
		{
			_indexViewModel = indexViewModel;
		}

		public ActionResult Index()
		{
			return View(_indexViewModel);
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
	}
}
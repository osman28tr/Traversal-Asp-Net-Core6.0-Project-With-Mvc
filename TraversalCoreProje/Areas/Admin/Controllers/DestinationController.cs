using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
	[Area("Admin")]
    public class DestinationController : Controller
	{
		DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());
		public IActionResult Index()
		{
			var values = destinationManager.TGetList();
			return View(values);
		}
		[HttpGet]
		public IActionResult AddDestination()
		{
			return View();
		}
		[HttpPost]
        public IActionResult AddDestination(Destination destination)
        {
			destinationManager.TInsert(destination);
            return RedirectToAction("Index");
        }
		public IActionResult DeleteDestination(int id)
		{	
			var values = destinationManager.GetById(id);
			destinationManager.TDelete(values);
			return RedirectToAction("Index");
		}
		public IActionResult deneme(int id)
		{
			return new EmptyResult();
		}
		[HttpGet]
		public IActionResult UpdateDestination(int id)
		{
            var values = destinationManager.GetById(id);
			return View(values);
        }
		[HttpPost]
        public IActionResult UpdateDestination(Destination destination)
        {
            destinationManager.TUpdate(destination);
            return RedirectToAction("Index");
        }
    }
}

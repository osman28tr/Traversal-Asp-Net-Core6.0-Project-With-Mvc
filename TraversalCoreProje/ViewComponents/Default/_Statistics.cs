using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents.Default
{
    public class _Statistics:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            using var context = new Context();
            ViewBag.deger1 = context.Destinations.Count();
            ViewBag.deger2 = context.Guides.Count();
            ViewBag.deger3 = "285";
            return View();
        }
    }
}

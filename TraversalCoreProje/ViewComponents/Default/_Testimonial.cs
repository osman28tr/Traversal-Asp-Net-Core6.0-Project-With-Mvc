using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents.Default
{
	public class _Testimonial:ViewComponent
	{
		TestimonialManager testimonialManager = new TestimonialManager(new EfTestimonialDal());
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}

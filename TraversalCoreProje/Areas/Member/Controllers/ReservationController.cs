using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TraversalCoreProje.Areas.Member.Controllers
{
    [Area("Member")]
    public class ReservationController : Controller
    {
        DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());

        ReservationManager reservationManager = new ReservationManager(new EfReservationDal());

        private readonly UserManager<AppUser> _userManager;
        public ReservationController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        public IActionResult MyCurrentReservation()
        {
            return View();
        }
        public IActionResult MyOldReservation()
        {
            return View();
        }
        public async Task<IActionResult> MyApprovalReservation()
        {
            var userValue = await _userManager.FindByNameAsync(User.Identity.Name);
            var reservationValue= reservationManager.GetListByApproval(userValue.Id);
            return View(reservationValue);
        }
        [HttpGet]
        public IActionResult NewReservation()
        {
            List<SelectListItem> values = (from x in destinationManager.TGetList()
                                          select new SelectListItem
                                          {
                                              Text=x.City,
                                              Value=x.DestinationId.ToString(),
                                          }).ToList();
            ViewBag.value = values;
            
            return View();
        }
        [HttpPost]
        public IActionResult NewReservation(Reservation reservation)
        {
            reservation.AppUserId = 3;
            reservation.Status = "Onay bekliyor.";
            reservationManager.TInsert(reservation);
            return RedirectToAction("MyCurrentReservation");
        }
    }
}

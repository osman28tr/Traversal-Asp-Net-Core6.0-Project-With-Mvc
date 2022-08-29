using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfReservationDal : GenericRepository<Reservation>, IReservationDal
    {
        public List<Reservation> GetListByAccepted(int appUserId)
        {
            using (var context = new Context())
            {
                return context.Reservations.Include(x => x.Destination).Where(x => x.AppUserId == appUserId &&
                x.Status == "Onaylandı").ToList();
            }
        }

        public List<Reservation> GetListByApproval(int appUserId)
        {
            using (var context = new Context())
            {
                return context.Reservations.Include(x => x.Destination).Where(x => x.AppUserId == appUserId &&
                x.Status == "Onay Bekliyor").ToList();
            }
        }

        public List<Reservation> GetListByOld(int appUserId)
        {
            using (var context = new Context())
            {
                return context.Reservations.Include(x => x.Destination).Where(x => x.AppUserId == appUserId &&
                x.Status == "Geçmiş Rezervasyon").ToList();
            }
        }
    }
}

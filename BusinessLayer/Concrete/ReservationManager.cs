using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ReservationManager : IReservationService
    {
        IReservationDal _reservationDal;
        public ReservationManager(IReservationDal reservationDal)
        {
            _reservationDal = reservationDal;
        }

        public List<Reservation> GetListByApproval(int appUserId)
        {
            return _reservationDal.GetListByFilter(x => x.AppUserId == appUserId && x.Status == "Onay Bekliyor").ToList();
        }

        public Reservation GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Reservation t)
        {
            throw new NotImplementedException();
        }

        public List<Reservation> TGetList()
        {
            return _reservationDal.GetList();
        }

        public void TInsert(Reservation t)
        {
            _reservationDal.Insert(t);
        }

        public void TUpdate(Reservation t)
        {
            throw new NotImplementedException();
        }
    }
}

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
        public Reservation GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Reservation> GetListByAccepted(int appUserId)
        {
            return _reservationDal.GetListByAccepted(appUserId);
        }

        public List<Reservation> GetListByApproval(int appUserId)
        {
            return _reservationDal.GetListByApproval(appUserId);
        }

        public List<Reservation> GetListByOld(int appUserId)
        {
            return _reservationDal.GetListByOld(appUserId);
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

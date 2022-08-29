using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IReservationDal: IGenericDal<Reservation>
    {
        List<Reservation> GetListByApproval(int appUserId);
        List<Reservation> GetListByAccepted(int appUserId);
        List<Reservation> GetListByOld(int appUserId);
    }
}

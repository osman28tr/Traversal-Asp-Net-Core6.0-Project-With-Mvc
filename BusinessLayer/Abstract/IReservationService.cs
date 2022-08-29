using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IReservationService: IGenericService<Reservation>
    {
        List<Reservation> GetListByApproval(int appUserId);
        List<Reservation> GetListByAccepted(int appUserId);
        List<Reservation> GetListByOld(int appUserId);
    }
}

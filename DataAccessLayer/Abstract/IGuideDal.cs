using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGuideDal: IGenericDal<Guide>
    {
        void ChangeToActiveByGuid(int id);
        void ChangeToPassiveByGuid(int id);
    }
}

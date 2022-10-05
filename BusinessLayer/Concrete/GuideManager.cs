using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class GuideManager : IGuideService
    {
        IGuideDal _guideDal;
        public GuideManager(IGuideDal guideDal)
        {
            _guideDal = guideDal;
        }

        public Guide GetById(int id)
        {
            return _guideDal.GetById(id);
        }

        public void TChangeToActiveByGuid(int id)
        {
            _guideDal.ChangeToActiveByGuid(id);
        }

        public void TChangeToPassiveByGuid(int id)
        {
            _guideDal.ChangeToPassiveByGuid(id);
        }

        public void TDelete(Guide t)
        {
            _guideDal.Delete(t);
        }

        public List<Guide> TGetList()
        {
            return _guideDal.GetList();
        }

        public void TInsert(Guide t)
        {
            _guideDal.Insert(t);
        }

        public void TUpdate(Guide t)
        {
            _guideDal.Update(t);
        }
    }
}

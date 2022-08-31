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
            throw new NotImplementedException();
        }

        public void TDelete(Guide t)
        {
            throw new NotImplementedException();
        }

        public List<Guide> TGetList()
        {
            return _guideDal.GetList();
        }

        public void TInsert(Guide t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Guide t)
        {
            throw new NotImplementedException();
        }
    }
}

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
	public class CommentManager : ICommentService
	{
		ICommentDal _commentDal;
		public CommentManager(ICommentDal commentDal)
		{
			_commentDal = commentDal;
		}
		public Comment GetById(int id)
		{
			return _commentDal.GetById(id);
		}
		public List<Comment> GetDestinationById(int destinationId)
		{
			return _commentDal.GetListByFilter(x => x.DestinationId == destinationId).ToList();
		}

		public List<Comment> GetListCommentWithNavDes()
		{
			return _commentDal.GetListCommentWithNavDes();
		}

		public void TDelete(Comment t)
		{
			_commentDal.Delete(t);
		}

		public List<Comment> TGetList()
		{
			return _commentDal.GetList();
		}

		public void TInsert(Comment t)
		{
			_commentDal.Insert(t);
		}

		public void TUpdate(Comment t)
		{
			throw new NotImplementedException();
		}
	}
}

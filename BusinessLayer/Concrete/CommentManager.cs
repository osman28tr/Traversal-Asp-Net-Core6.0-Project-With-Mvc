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
			throw new NotImplementedException();
		}
		public List<Comment> GetDestinationById(int destinationId)
		{
			return _commentDal.GetListByFilter(x => x.DestinationId == destinationId).ToList();
		}

		public void TDelete(Comment t)
		{
			throw new NotImplementedException();
		}

		public List<Comment> TGetList()
		{
			throw new NotImplementedException();
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

using DataAccessLayer.Abstract;
using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concret.Repositories
{
	public class CategoryReprository : ICategoryDL
	{
		public void Delte(Category p)
		{
			throw new NotImplementedException();
		}

		public void Insert(Category p)
		{
			throw new NotImplementedException();
		}

		public List<Category> List()
		{
			throw new NotImplementedException();
		}

		public List<Category> List(Expression<Func<Category, bool>> filter)
		{
			throw new NotImplementedException();
		}

		public void Update(Category p)
		{
			throw new NotImplementedException();
		}
	}
}

﻿using DataAccessLayer.Concret.Repositories;
using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class CategoryManager
	{
		GenericRepository<Category> repo = new GenericRepository<Category>();
	    public List<Category> GetAllBL()
		{
			return repo.List();
		}
		public void CategoryAddBL(Category p)
		{

		}
	}
}

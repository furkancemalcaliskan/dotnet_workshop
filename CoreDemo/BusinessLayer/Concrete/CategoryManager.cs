﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void AddT(Category t)
        {
            _categoryDal.Insert(t);
        }

        public void DeleteT(Category t)
        {
            _categoryDal.Delete(t);
        }

        public void UpdateT(Category t)
        {
            _categoryDal.Update(t);
        }

        public List<Category> GetList()
        {
            return _categoryDal.GetListAll();
        }

        public Category GetById(int id)
        {
            return _categoryDal.GetById(id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using LibraryManagementSystemWithEF.BusinessLayer.Abstract;
using LibraryManagementSystemWithEF.DAL.Abstract;
using LibraryManagementSystemWithEF.Models;

namespace LibraryManagementSystemWithEF.BusinessLayer.Concrate
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDAL _categoryDal;

        public CategoryManager(ICategoryDAL categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public void TAdd(Category t)
        {
            _categoryDal.Add(t);
        }

        public void TDelete(Category t)
        {
            _categoryDal.Delete(t);
        }

        public List<Category> TGetAll(Expression<Func<Category, bool>> filter = null)
        {
            return _categoryDal.GetAll(filter);
        }

        public Category TGetById(int id)
        {
            return _categoryDal.GetByID(id);
        }

        public void TUpdate(Category t)
        { 
            _categoryDal.Update(t);
        }
    }
}

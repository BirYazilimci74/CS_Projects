using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using LibraryManagementSystemWithEF.DAL.Abstract;

namespace LibraryManagementSystemWithEF.DAL.Repository
{
    internal class GenericRepository<T> : IGenericDAL<T> where T : class
    {
        private readonly LibraryContext _context = new LibraryContext();

        public void Add(T t)
        {
            var entity = _context.Entry(t);
            entity.State = EntityState.Added;
            //_context.Set<T>().Add(t);
            _context.SaveChanges();
        }

        public void Delete(T t)
        {
            var entity = _context.Entry(t);
            entity.State = EntityState.Deleted;
            //_context.Set<T>().Remove(t);
            _context.SaveChanges();
        }

        public List<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            return filter == null ? _context.Set<T>().ToList() : _context.Set<T>().Where(filter).ToList();
        }

        public T GetByID(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Update(T t)
        {
            var entity = _context.Entry(t);
            entity.State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}

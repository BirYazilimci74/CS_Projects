using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using LibraryManagementSystemWithEF.DAL.Abstract;

namespace LibraryManagementSystemWithEF.DAL.Repository
{
    internal class GenericRepository<T> : IGenericDAL<T> where T : class
    {
    private LibraryContext _context = new LibraryContext();

    public void Add(T t)
    {
        _context.Set<T>().Add(t);
        _context.SaveChanges();
    }

    public void Delete(T t)
    {
        _context.Set<T>().Remove(t);
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

    public void Return(T t)
    {
        throw new NotImplementedException();
    }

    public void Update(T t)
    {
        _context.SaveChanges();
    }


    }
}

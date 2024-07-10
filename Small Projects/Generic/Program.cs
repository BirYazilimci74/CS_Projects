using System;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            ICustomerDAL customerDAL= new CustomerDAL();
            IProductDAL productDAL= new ProductDAL();
            customerDAL.Add(new Customer());
            productDAL.GetList();

        }
    }

    interface IProductDAL:IRepository<Product>        // Dal = data access layer. This contains server functions.
    {
        
    }

    interface ICustomerDAL:IRepository<Customer>        // Dal = data access layer. This contains server functions.
    {
        
    }

    interface IRepository<T>
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        T GetByID(int id);
        List<T> GetList();
    }

    
}
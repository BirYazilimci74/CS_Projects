using Generic;

namespace Generic
{
    class ProductDAL:IProductDAL
    {
        public void Add(Product entity)
        {
            Console.WriteLine("Product Added");
        }
        public void Update(Product entity)
        {
            Console.WriteLine("Product Upadated");
        }
        public void Delete(Product entity)
        {
            Console.WriteLine("Product Deleted");
        }

        public Product GetByID(int id)
        {
            Console.WriteLine("Product");
            return null;
        }
        public List<Product> GetList()
        {
            Console.WriteLine("Product List");
            return null;
        }
    }

    class CustomerDAL:ICustomerDAL
    {
        public void Add(Customer entity)
        {
            Console.WriteLine("Customer Added");
        }
        public void Update(Customer entity)
        {
            Console.WriteLine("Customer Upadated");
        }
        public void Delete(Customer entity)
        {
            Console.WriteLine("Customer Deleted");
        }

        public Customer GetByID(int id)
        {
            Console.WriteLine("Customer");
            return null;
        }
        public List<Customer> GetList()
        {
            Console.WriteLine("Customer List");
            return null;
        }
    }

}
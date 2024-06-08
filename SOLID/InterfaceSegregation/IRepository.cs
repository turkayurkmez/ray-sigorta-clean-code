using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{

    public class Product
    {

    }

    public class Order
    {

    }
    public interface IRepository<T> where T : class
    {
        T GetById(int id);
        IList<T> GetAll();

     
    }

    public interface ISearchable<T> where T : class
    {
        IList<T> SearchByName(string name);
    }
    public class ProductRepository : IRepository<Product>, ISearchable<Product>
    {
        public IList<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Product> SearchByName(string name)
        {
            throw new NotImplementedException();
        }
    }

    public class OrderRepository : IRepository<Order>
    {
        public IList<Order> GetAll()
        {
            throw new NotImplementedException();
        }

        public Order GetById(int id)
        {
            throw new NotImplementedException();
        }

       
    }

    public class Searcher<T> where T:class
    {
        public void Search(ISearchable<T> searchable,string name)
        {
            searchable.SearchByName(name);
        }
    }
}

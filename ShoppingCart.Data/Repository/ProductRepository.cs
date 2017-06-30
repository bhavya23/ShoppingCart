using ShoppingCart.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Data.Repository
{
   public class ProductRepository : IRepository<Product>
    {
        List<Product> lst = new List<Product> { new Product() { ID = 1, Name = "Laptop", Price = 500, Qty = 7 } ,
        new Product() { ID = 2, Name = "Mobile", Price = 200, Qty = 8 }};
        public IEnumerable<Product> GetAll()
        {
            return lst;
        }

        public void Add(Product entity)
        {
            lst.Add(entity);
        }

        public void Delete(Product entity)
        {
            lst.Remove(entity) ;
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product FindById(int Id)
        {
            return lst.Where(x=>x.ID==Id).FirstOrDefault();
        }

        public List<Product> SearchBy(string searchValue)
        {
            throw new NotImplementedException();
        }
    }
}

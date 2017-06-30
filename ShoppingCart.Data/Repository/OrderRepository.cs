using ShoppingCart.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Data.Repository
{
    public class OrderRepository : IRepository<Order>
    {
        public IEnumerable<Order> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Add(Order entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Order entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Order entity)
        {
            throw new NotImplementedException();
        }

        public Order FindById(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Order> SearchBy(string searchValue)
        {
            throw new NotImplementedException();
        }
    }
}

using ShoppingCart.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Data.Repository
{
    public class CustomerRepository : IRepository<Customer>
    {
        List<Customer> lst = new List<Customer>();
        public IEnumerable<Customer> GetAll()
        {
            return lst;
        }

        public void Add(Customer entity)
        {
            lst.Add(entity);
        }

        public void Delete(Customer entity)
        {
            lst.Remove(entity);
        }

        public void Update(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Customer FindById(int Id)
        {
            return lst.Where(z => z.Id == Id).FirstOrDefault();
        }

        public List<Customer> SearchBy(string searchValue)
        {
            throw new NotImplementedException();
        }
    }
}

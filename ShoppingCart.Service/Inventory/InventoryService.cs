using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingCart.Data.Repository;
using ShoppingCart.Data.Entity;
namespace ShoppingCart.Service.Inventory
{
    public class InventoryService : IInventoryService
    {
        IRepository<Product> productRepository;
        public InventoryService()
        {
            productRepository = new ProductRepository();
        }
       
        public bool CheckInventory(int productId, int quantity)
        {
            // Get the product by ID  
            Product p = productRepository.FindById(productId);
            
            //check if the Inventory quantity is greater than or equal to order placed
            if (p != null)
            {
                return p.Qty >= quantity;
            }
            throw new IndexOutOfRangeException("Product Doesn't Exist");
        }
    }
}

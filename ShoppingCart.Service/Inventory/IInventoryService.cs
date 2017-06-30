using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Service.Inventory
{
    public interface IInventoryService
    {
        bool CheckInventory(int productId, int quantity);
    }
}

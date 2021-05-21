using System.Collections.Generic;

namespace Facade
{
    public class InventoryService
    {
        private List<Product> products;


        void addProduct(Product product)
        {
            products.Add(product);
        }

        void removeProduct(Product product)
        {
            products.Remove(product);
        }
    }
}
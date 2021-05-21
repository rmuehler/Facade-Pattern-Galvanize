using System.Collections.Generic;

namespace Facade
{
    public class InventoryService
    {
        private List<Product> _products;
        void addProduct(Product product)
        {
            _products.Add(product);
        }

        void removeProduct(Product product)
        {
            _products.Remove(product);
        }
    }
}
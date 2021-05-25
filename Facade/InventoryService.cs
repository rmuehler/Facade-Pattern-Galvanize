using System.Collections.Generic;

namespace Facade
{
    public class InventoryService
    {
        private List<Product> _products;

        public void addProduct(Product product)
        {
            _products.Add(product);
        }

        public void removeProduct(Product product)
        {
            _products.Remove(product);
        }
    }
}
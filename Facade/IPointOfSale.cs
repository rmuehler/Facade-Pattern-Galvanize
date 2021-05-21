namespace Facade
{
    public interface IPointOfSale
    {
        void SellProduct(string productName, string customerName, string shippingAddress);
        
        void AddProduct(string name, int pricing, int quantity);

        void processPayment(string customerName);

        void ShipProduct(string name);
    }
}
namespace Facade
{
    public interface IPointOfSale
    {
        Product AddProduct(string name, int pricing, int quantity);

        public void SellProduct(Product product);

        public Shipment processPayment(Payment payment, Product product);

        public void ShipProduct(Shipment shipment);
    }
}
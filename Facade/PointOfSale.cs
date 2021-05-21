namespace Facade
{
    public class PointOfSale : IPointOfSale
    {
        private InventoryService _inventoryService;
        private ShippingService _shippingService;
        private PaymentService _paymentService;


        public void SellProduct(string productName, string customerName, string shippingAddress)
        {
            _inventoryService.removeProduct(new Product());
            
            _paymentService.addShipment(new Shipment());
        }

        public void AddProduct(string name, int pricing, int quantity)
        {
            throw new System.NotImplementedException();
        }

        public void processPayment(string customerName)
        {
            throw new System.NotImplementedException();
        }

        public void ShipProduct(string name)
        {
            throw new System.NotImplementedException();
        }
    }
}
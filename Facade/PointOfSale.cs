namespace Facade
{
    public class PointOfSale : IPointOfSale
    {
        private InventoryService _inventoryService;
        private ShippingService _shippingService;
        private PaymentService _paymentService;


        public void SellProduct(Product product)
        {
            _inventoryService.removeProduct(product);
        }

        public Product AddProduct(string name, int pricing, int quantity)
        {
            var product = new Product()
            {
                Name = name,
                Pricing = pricing,
                Quantity = quantity
            };
            _inventoryService.addProduct(product);
            return product;
        }

        //remove payment, get it ready for shipping
        public Shipment processPayment(Payment payment, Product product)
        {
            _paymentService.removePayment(payment);

            var shipment = new Shipment()
            {
                Product = product,
                Address = payment.customerAddress,
                Quantity = product.Quantity
            };
            _shippingService.addShipment(shipment);
            return shipment;
        }

        public void ShipProduct(Shipment shipment)
        {
            _shippingService.removeShipment(shipment);
        }
    }
}

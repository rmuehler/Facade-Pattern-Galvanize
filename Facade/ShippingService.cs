using System.Collections.Generic;

namespace Facade
{
    public class ShippingService
    {
        private List<Shipment> _pendingShipments;


        public void addShipment(Shipment shipment)
        {
            _pendingShipments.Add(shipment);
        }

        public void removeShipment(Shipment shipment)
        {
            _pendingShipments.Remove(shipment);
        }
    }
}
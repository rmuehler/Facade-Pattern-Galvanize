using System.Collections.Generic;

namespace Facade
{
    public class PaymentService
    {
        private List<Shipment> _pendingPayments;


        public void addShipment(Shipment shipment)
        {
            _pendingPayments.Add(shipment);
        }

        public void removeShipment(Shipment shipment)
        {
            _pendingPayments.Remove(shipment);
        }
    }
}
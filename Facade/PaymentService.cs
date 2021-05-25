using System.Collections.Generic;

namespace Facade
{
    public class PaymentService
    {
        private List<Payment> _pendingPayments;


        public void addPayment(Payment payment)
        {
            _pendingPayments.Add(payment);
        }

        public void removePayment(Payment payment)
        {
            _pendingPayments.Remove(payment);
        }
    }
}
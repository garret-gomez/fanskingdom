using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreLibrary3
{
    public class PaymentModel
    {
        public string CardType { get; set; }
        public bool Allowed { get; set; }
        public int CardNumber { get; set; }
        public DateTime CardExpMo { get; set; }
        public DateTime CardExpYr { get; set; }
        public string BillingAddress { get; set; }
        public string BillingCity { get; set; }
        public string BillingState { get; set; }
        public string BillingPostalCode { get; set; }
        public string BillingCountry { get; set; }
        public CustomerModel CardOwner { get; set; }

    }
}

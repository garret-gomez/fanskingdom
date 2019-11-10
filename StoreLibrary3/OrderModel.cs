using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreLibrary3
{
    public class OrderModel
    {
        public int OrderNumber { get; set; }
        public List<List<OrderDetailsModel>> ItemsOrdered { get; set; } = new List<List<OrderDetailsModel>>();
        public PaymentModel EnteredCard { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime OrderShipDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public StateSalesTaxModel SalesTax { get; set; }
        public decimal OrderTotal { get; set; }
        public bool ReadyForShipping { get; set; }
        public bool OrderShipped { get; set; }
        public bool OrderDeleted { get; set; }
        public bool OrderPaid { get; set; }
        public DateTime PaymentDate { get; set; }
        public CustomerModel OrderOwner { get; set; }

    }
}

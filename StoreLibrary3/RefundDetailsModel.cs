using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreLibrary3
{
    public class RefundDetailsModel
    {
        public int RefundItemNumber { get; set; }
        public OrderDetailsModel OrderItemRefunded { get; set; }
        public ProductModel ItemRefunded { get; set; }
        public int RefundedQuantity { get; set; }
        public decimal RefundedAmount { get; set; }

    }
}

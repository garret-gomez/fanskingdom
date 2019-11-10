using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreLibrary3
{
    public class OrderDetailsModel
    {
        public int OrderItemNumber { get; set; }
        public ProductModel ProductPurchased { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal Discount { get; set; }
        public decimal ItemTotal { get; set; }
        public SizeModel SizeSelected { get; set; }
        public ColorModel ColorSelected { get; set; }
        public bool ItemShipped { get; set; }
        public DateTime ItemShipDate { get; set; }
        public DateTime BillDate { get; set; }
        public OrderModel ParentOrder { get; set; }

    }
}

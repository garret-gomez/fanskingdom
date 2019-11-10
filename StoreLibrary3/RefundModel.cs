using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreLibrary3
{
    public class RefundModel
    {
        public int RefundNumber { get; set; }
        public bool OrderRefunded { get; set; }
        public List<List<RefundDetailsModel>> ItemsRefunded { get; set; } = new List<List<RefundDetailsModel>>();
        public PaymentModel RefundedCard { get; set; }
        public string RefundStatus { get; set; }
        public DateTime RefundDate { get; set; }
        public decimal RefundTotal { get; set; }

    }
}

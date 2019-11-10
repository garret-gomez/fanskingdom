using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreLibrary3
{
    public class CustomerModel
    {
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<PaymentModel> CreditCards { get; set; } = new List<PaymentModel>();
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipState { get; set; }
        public string ShipCountry { get; set; }
        public DateTime DateEntered { get; set; }
        public List<WishListModel> WishList { get; set; } = new List<WishListModel>();
        public List<OrderModel> Orders { get; set; } = new List<OrderModel>();
        public bool Verified { get; set; }

    }
}

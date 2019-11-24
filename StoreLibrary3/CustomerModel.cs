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
    
    //checks values for customer 
    if (CustomerFirstName == "") 
    {
        lblCustomerFirstName.Text = String.Format("Required");
    }
    else if (CustomerLastName == "")
    {
        lblCustomerLastName.Text = String.Format("Required");
    }
    else if (Address == "")
    {
        Address.Text = String.Format("Required");
    }
    else if (City == "")
    {
        lblCity.Text = String.Format("Required");
    }    
    else if (State == "")
    {
        lblState.Text = String.Format("Required");
    }
    else if (PostalCode == "")
    {
        lblPostalCode.Text = String.Format("Required");
    } 
    else if (txtPostalCode.Text.Length < 5 || txtPostalCode.Text.Length > 5)
    {
        lblCustomerLastName.Text = String.Format("Please enter a proper postal code");
    }
    else if (Country == "")
    {
        lblCountry.Text = String.Format("Required");
    }
    else if (Phone == "")
    {
        lblPhone.Text = String.Format("Required");
    }
    else if (txtPhone.Text.Length < 10 || txtPhone.Text.Length >10)
    {
        lblPhone.Text = String.Format("Please enter a valid phone number");
    } 
    else if (Email == "")
    {
        lblEmail.Text = String.Format("Required");
    } 
    else if (Password == "")
    {
        lblPassword.Text = String.Format("Required");
    }
     else if (txtPassword.Text.Length < 8)
    {
        lblPassword.Text = String.Format("Please enter a password with at least 8 characters");
    } 
    else if (ShipAddress == "")
    {
        lblShipAddress.Text = String.Format("Required");
    }
     else if (ShipCity == "")
    {
        lblShipCity.Text = String.Format("Required");
    }
     else if (ShipState == "")
    {
        lblShipState.Text = String.Format("Required");
    }
     else if (ShipCountry == "")
    {
        lblShipCountry.Text = String.Format("Required");
    }
    else
    {
        //display confirmation of registration
    }
}

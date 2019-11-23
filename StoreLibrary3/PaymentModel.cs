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
    //after clicking submit button checks all fields
    {
      if (CardOwner == "") 
      { 
          lblCardOwner.Text = String.Format("Required"); 
      } 
      else if (CarNumber == "") 
      {
          lblCardOwner.Text = String.Format("Required");
      } 
      else if (CardNumber.Text.Length < 16) 
      {
        lblCardNumber.Text = String.Format("Not a Valid Card Number");
      } 
      else if (CardType.Text == "Master Card" && (txtCreditNum.Text.StartsWith("51") || txtCreditNum.Text.StartsWith("52") || txtCreditNum.Text.StartsWith("53") || txtCreditNum.Text.StartsWith("54")) == false) 
      {
          lblCardNumber.Text = String.Format("Not correct Master Card number");
      } 
      else if (CardType.Text == "Visa" && txtCreditNum.Text.StartsWith("4") == false) 
      {
          lblCardType.Text = String.Format("Not correct Visa number");
      } 
      elseif (CardExpMO = " ") 
      {
          lblCardExpMo.Text = String.Format("Required");
      } 
      elseif (CardExpYr = " ")
      {
          lblCardExpYr.Text = String.Format("Required");
      } 
      elseif (BillingAdress.Text = " ")
      {
          lblBillingAddress.Text = String.Format("Required");
      } 
      elseif (BillingCity.Text = "")
      {
          lblBillingCity.Text = String.Format("Required");
      } 
      elseif (BillingState = "")
      {
          lblBillingState.Text = String.Format("Required");
      } 
      elseif (BillingPostalCode.Text = "")
      {
          lblBillingPostalCode.Text = String.Format("Required");
      } 
      elseif (BillingPostalCode.Text.Length < 5)
      {
          lblBillingPostalCode.Text = String.Format("Invalid postal code");
      }
      elseif (BillingCountry = "")
      {
          lblBillingCountry.Text = String.Format("Required");
      }
      else 
      { 
          //display confirmation
      }
    }
}

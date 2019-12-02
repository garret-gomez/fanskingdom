using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreUI
{
    public partial class CustomerLoginForm : Form
    {
        public CustomerLoginForm()
        {
            InitializeComponent();
        }
        //after clicking login button
        {
            //variables
            string email, password; 
            //input data
            email = emailLoginTextBox.Text;
            password = passwordLoginTextBox.Text; 
            //checks input data 
            if (email == "")
            {
                loginEmailLabel.Text = string.Format("Please enter an email");
            } 
            else if(password == "")
            {
                passwordLoginLabel.Text = string.Format("Please enter a password");
            }
            else if(password != " customers password")
            {
                passwordLoginLabel.Text = string.Format("Please enter correct password");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreLibrary3
{
    public class SqlConnector : IDataConnection
    {
        // TODO - make the AddCustomer method actually save to the database. 
        /// <summary>
        /// Saves a new customer to the database.
        /// </summary>
        /// <param name="model">The customer information.</param>
        /// <returns>The customer information, incl. the unique identifier.</returns>
        public CustomerModel AddCustomer(CustomerModel model)
        {
            model.Id = 1;

            return model; 
        }
    }
}

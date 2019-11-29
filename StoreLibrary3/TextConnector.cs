using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreLibrary3
{
    public class TextConnector : IDataConnection
    {
        // TODO - Wire up the AddCustomer for text files
        public CustomerModel AddCustomer(CustomerModel model)
        {
            model.Id = 1;

            return model;
        }
    }
}

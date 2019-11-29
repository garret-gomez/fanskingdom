using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreLibrary3
{
    public interface IDataConnection
    {
        CustomerModel AddCustomer(CustomerModel model);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreLibrary3
{
    public class WishListModel
    {
        public CustomerModel WishListOwner { get; set; }
        public ProductModel WishListItem { get; set; }

    }
}

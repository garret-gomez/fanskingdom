using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreLibrary3
{
    public class CategoryMemberModel
    {
        public string MemberName { get; set; }
        public byte MemberPicture { get; set; }
        public bool Active { get; set; }
        public List<ProductModel> Products { get; set; } = new List<ProductModel>();

    }
}

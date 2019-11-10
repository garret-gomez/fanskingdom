using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreLibrary3
{
    public class CategoryModel
    {
        public List<CategoryMemberModel> CategoryMembers { get; set; } = new List<CategoryMemberModel>();
        public string CategoryName { get; set; }

    }
}

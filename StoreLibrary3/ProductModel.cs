using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreLibrary3
{
    public class ProductModel
    {
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public List<SizeModel> UnitSize { get; set; } = new List<SizeModel>();
        public List<ColorModel> UnitColor { get; set; } = new List<ColorModel>();
        public decimal Discount { get; set; }
        public decimal UnitWeight { get; set; }
        public int UnitsInStock { get; set; }
        public int UnitsOnOrder { get; set; }
        public int ReorderLevel { get; set; }
        public bool ProductAvailable { get; set; }
        public bool DiscountAvailable { get; set; }
        public byte ProductPicture { get; set; }
        public string Note { get; set; }
        public CategoryMemberModel ProductCategory { get; set; }

    }
}

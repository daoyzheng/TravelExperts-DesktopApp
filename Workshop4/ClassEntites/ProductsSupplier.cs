using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEntites
{
    public class ProductsSupplier
    {
        public int ProductSupplierId { get; set; }
        public int? ProductId { get; set; } // Can be NULL
        public int? SupplierId { get; set; } // Can be NULL
    }
}

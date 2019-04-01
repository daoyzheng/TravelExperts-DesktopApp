using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEntites {
    public class DummyPackage {
        public int PackageId { get; set; }

        public string PkgName { get; set; }

        public DateTime? PkgStartDate { get; set; } 

        public DateTime? PkgEndDate { get; set; } 

        public decimal PkgBasePrice { get; set; }

        public string PkgDesc { get; set; }

        public decimal? PkgAgencyCommission { get; set; }
        
        public int ProductSupplierId { get; set; }

        public string ProdName { get; set; }

        public string SuppName { get; set; } 
    }
}

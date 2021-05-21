using System;
using System.Collections.Generic;
using System.Text;

namespace DepartmentalStoreApp.Domain
{
    public class Supply
    {
        public long SupplyId { get; set; }
        public long ProductId { get; set; }
        public long SupplierId { get; set; }
        public DateTime DateOfSupply { get; set; }
        public int QuantitySupplied { get; set; }
        public Product Product { get; set; }
        public Supplier Supplier { get; set; }
    }
}

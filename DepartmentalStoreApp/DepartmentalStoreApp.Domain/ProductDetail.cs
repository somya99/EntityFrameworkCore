using System;
using System.Collections.Generic;
using System.Text;

namespace DepartmentalStoreApp.Domain
{
    public class ProductDetail
    {
        public long ProductId { get; set; }
        public float CostPrice { get; set; }
        public float SellingPrice { get; set; }
        public DateTime DateOfManufacture { get; set; }
        public Product Product { get; set; }
    }
}

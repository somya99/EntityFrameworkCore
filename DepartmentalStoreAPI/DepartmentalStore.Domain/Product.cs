using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DepartmentalStoreAPI.DepartmentalStore.Domain
{
    public class Product
    {
        public Product()
        {
            ProductCategory = new List<ProductCategory>();
            Supply = new List<Supply>();
        }
        public long ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public string Manufacturer { get; set; }
        public int CurrentQuantity { get; set; }
        public List<ProductCategory> ProductCategory { get; set; }
        public Inventory Inventory { get; set; }
        public ProductDetail ProductDetail { get; set; }
        public List<Supply> Supply { get; set; }
    }
}

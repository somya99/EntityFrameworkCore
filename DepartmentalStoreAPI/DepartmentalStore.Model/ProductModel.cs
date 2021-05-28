using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DepartmentalStoreAPI.DepartmentalStore.Model
{
    public class ProductModel
    {
        public long ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public string Manufacturer { get; set; }
        public int CurrentQuantity { get; set; }
        public ProductDetailModel ProductDetail { get; set; }
        public InventoryModel Inventory { get; set; }
        
    }
}

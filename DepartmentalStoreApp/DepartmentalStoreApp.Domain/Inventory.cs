using System;
using System.Collections.Generic;
using System.Text;

namespace DepartmentalStoreApp.Domain
{
    public class Inventory
    {
        public long InventoryId { get; set; }
        public long ProductId { get; set; }
        public int TotalQuantity { get; set; }
        public bool InStock { get; set; }
        public Product Product { get; set; }
    }
}

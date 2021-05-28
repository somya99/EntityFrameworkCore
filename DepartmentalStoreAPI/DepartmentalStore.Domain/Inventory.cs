using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DepartmentalStoreAPI.DepartmentalStore.Domain
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

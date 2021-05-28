using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DepartmentalStoreAPI.DepartmentalStore.Model
{
    public class InventoryModel
    {
        public long InventoryId { get; set; }
        public long ProductId { get; set; }
        public int TotalQuantity { get; set; }
        public bool InStock { get; set; }
    }
}

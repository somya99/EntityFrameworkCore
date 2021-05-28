using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DepartmentalStoreAPI.DepartmentalStore.Model
{
    public class ProductDetailModel
    {
        public long ProductId { get; set; }
        public float CostPrice { get; set; }
        public float SellingPrice { get; set; }
        public DateTime DateOfManufacture { get; set; }
    }
}

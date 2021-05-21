using System;
using System.Collections.Generic;
using System.Text;

namespace DepartmentalStoreApp.Domain
{
    public class Category
    {
        public Category()
        {
            ProductCategory = new List<ProductCategory>();
        }
        public long CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public List<ProductCategory> ProductCategory { get; set; }
    }
}

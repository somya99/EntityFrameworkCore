using System;
using System.Collections.Generic;
using System.Text;

namespace DepartmentalStoreApp.Domain
{
    public class Supplier
    {
        public long SupplierId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public List<Supply> Supply { get; set; }
    }
}

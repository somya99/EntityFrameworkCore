using System;
using System.Collections.Generic;
using System.Text;

namespace DepartmentalStoreApp.Domain
{
    public class Address
    {
        public Address()
        {
            Staff = new List<Staff>();
        }
        public long AddressId { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Pincode { get; set; }
        public List<Staff> Staff { get; set; }
    }
}

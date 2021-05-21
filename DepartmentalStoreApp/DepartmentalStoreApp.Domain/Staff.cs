using System;
using System.Collections.Generic;
using System.Text;

namespace DepartmentalStoreApp.Domain
{
    public class Staff
    {
        public long StaffId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNo { get; set; }
        public string Gender { get; set; }
        public long AddressId { get; set; }
        public long StaffRoleId { get; set; }
        public long Salary { get; set; }
        public Address Address { get; set; }
        public StaffRole StaffRole { get; set; }
    }
}

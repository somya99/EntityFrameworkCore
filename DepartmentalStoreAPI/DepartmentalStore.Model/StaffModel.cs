using DepartmentalStoreAPI.DepartmentalStore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DepartmentalStoreAPI.DepartmentalStore.Model
{
    public class StaffModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNo { get; set; }
        public string Gender { get; set; }
        //public string StaffAddressLine1 { get; set; }
        //public string StaffAddressLine2 { get; set; }
        //public string StaffCity { get; set; }
        //public string StaffState { get; set; }
        //public string StaffPincode { get; set; }
        public AddressModel Address { get; set; }
        public StaffRoleModel StaffRole { get; set; }
        public long Salary { get; set; }
    }
}

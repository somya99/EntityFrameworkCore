using System;
using System.Collections.Generic;
using System.Text;

namespace DepartmentalStoreApp.Domain
{
    public class StaffRole
    {
        public StaffRole()
        {
            Staff = new List<Staff>();
        }
        public long StaffRoleId { get; set; }
        public string RoleName { get; set; }
        public string Description { get; set; }
        public List<Staff> Staff { get; set; }
    }
}

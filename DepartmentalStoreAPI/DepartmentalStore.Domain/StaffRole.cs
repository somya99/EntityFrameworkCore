using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DepartmentalStoreAPI.DepartmentalStore.Domain
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

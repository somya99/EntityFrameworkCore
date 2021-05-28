using DepartmentalStoreAPI.DepartmentalStore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DepartmentalStoreAPI.DepartmentalStore.Data
{
    public interface IDStoreRepository
    {
        // General 
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveChangesAsync();

        //Staff
        Task<Staff[]> GetAllStaffAsync(bool includeRole = false);
        Task<Staff> GetStaffAsync(long StaffId, bool includeRole = false);
        Task<Staff> GetStaffByFirstNameAsync(string FirstName, bool includeRole = false);
        Task<Staff> GetStaffByLastNameAsync(string LastName, bool includeRole = false);
        Task<Staff> GetStaffByPhoneAsync(string PhoneNo, bool includeRole = false);
        Task<Staff[]> GetAllStaffByRole(string RoleName, bool includeRole = false);

        //Product
        Task<Product[]> GetAllProductAsync(bool includeInventory = false);
        Task<Product> GetProductAsync(long productId, bool includeInventory = false);
        Task<Product> GetProductByNameAsync(string productname, bool includeInventory = false);
        Task<Product[]> GetAllProductByInStock(bool includeInventory = false);
        Task<Product[]> GetAllProductByOutOfStock(bool includeInventory = false);

        //Staff Role
        Task<StaffRole> GetStaffRoleAsync(long staffId);

        //Product Detail
        Task<ProductDetail> GetProductDetailAsync(long productId);

        //Inventory
        Task<Inventory> GetInventoryAsync(long inventoryId);
    }
}

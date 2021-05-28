using DepartmentalStoreAPI.DepartmentalStore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DepartmentalStoreAPI.DepartmentalStore.Data
{
    public class DStoreRepository : IDStoreRepository
    {
        private readonly DStoreContext _context;
        private readonly ILogger<DStoreRepository> _logger;

        public DStoreRepository(DStoreContext context, ILogger<DStoreRepository> logger)
        {
            _context = context;
            _logger = logger;
        }
        public void Add<T>(T entity) where T : class
        {
            _logger.LogInformation($"Adding an object of type {entity.GetType()} to the context.");
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _logger.LogInformation($"Removing an object of type {entity.GetType()} to the context.");
            _context.Remove(entity);
        }
        public async Task<bool> SaveChangesAsync()
        {
            _logger.LogInformation($"Attempitng to save the changes in the context");

            return (await _context.SaveChangesAsync()) > 0;
        }

        public async Task<Product[]> GetAllProductAsync(bool includeInventory = false)
        {
            _logger.LogInformation($"Getting all Product");

            IQueryable<Product> query = _context.Product.Include(a => a.ProductDetail);

            if (includeInventory)
            {
                query = query
                  .Include(r => r.Inventory);
            }
            
            // Order It
            query = query.OrderByDescending(c => c.ProductId);

            return await query.ToArrayAsync();
        }


        public async Task<Product[]> GetAllProductByInStock(bool includeInventory = false)
        {
            _logger.LogInformation($"Getting all Product");

            IQueryable<Product> query = _context.Product.Include(a => a.ProductDetail);
                

            if (includeInventory)
            {
                query = query
                  .Include(c => c.Inventory);
            }

            // Order It
            query = query.OrderByDescending(c => c.ProductId)
              .Where(c => c.Inventory.InStock == true);

            return await query.ToArrayAsync();
        }

        public async Task<Product[]> GetAllProductByOutOfStock(bool includeInventory = false)
        {
            _logger.LogInformation($"Getting all Product");

            IQueryable<Product> query = _context.Product.Include(a => a.ProductDetail);


            if (includeInventory)
            {
                query = query
                  .Include(c => c.Inventory);
            }

            // Order It
            query = query.OrderByDescending(c => c.ProductId)
              .Where(c => c.Inventory.InStock == false);

            return await query.ToArrayAsync();
        }

        public async Task<Staff[]> GetAllStaffAsync(bool includeRole = false)
        {
            _logger.LogInformation($"Getting all Staff");

            IQueryable<Staff> query = _context.Staff
                .Include(a => a.Address);

            if (includeRole)
            {
                query = query
                  .Include(r => r.StaffRole);
            }

            // Order It
            query = query.OrderByDescending(c => c.StaffId);

            return await query.ToArrayAsync();
        }

        public async Task<Staff[]> GetAllStaffByRole(string rolename, bool includeRole = false)
        {
            _logger.LogInformation($"Getting all Staff");

            IQueryable<Staff> query = _context.Staff
                .Include(c => c.Address);

            if (includeRole)
            {
                query = query
                  .Include(c => c.StaffRole);
            }

            // Order It
            query = query.OrderByDescending(c => c.StaffId)
              .Where(c => c.StaffRole.RoleName == rolename);

            return await query.ToArrayAsync();
        }

        public async Task<Product> GetProductAsync(long productId, bool includeInventory = false)
        {
            _logger.LogInformation($"Getting a Product for {productId}");

            IQueryable<Product> query = _context.Product.Include(a => a.ProductDetail);

            if (includeInventory)
            {
                query = query
                  .Include(r => r.Inventory);
            } 

            // Query It
            query = query.Where(c => c.ProductId == productId);

            return await query.FirstOrDefaultAsync();
        }

        public async Task<Product> GetProductByNameAsync(string productname, bool includeInventory = false)
        {
            _logger.LogInformation($"Getting a Product for {productname}");

            IQueryable<Product> query = _context.Product.Include(a => a.ProductDetail);

            if (includeInventory)
            {
                query = query
                  .Include(r => r.Inventory);
            }

            // Query It
            query = query.Where(c => c.ProductName == productname);

            return await query.FirstOrDefaultAsync();
        }

        public async Task<Staff> GetStaffAsync(long staffId, bool includeRole = false)
        {
            _logger.LogInformation($"Getting a Staff for {staffId}");

            IQueryable<Staff> query = _context.Staff
                .Include(c => c.Address);

            if (includeRole)
            {
                query = query.Include(c => c.StaffRole);
            }

            // Query It
            query = query.Where(c => c.StaffId == staffId);

            return await query.FirstOrDefaultAsync();
        }

        public async Task<Staff> GetStaffByFirstNameAsync(string firstname, bool includeRole = false)
        {
            _logger.LogInformation($"Getting a Staff for {firstname}");

            IQueryable<Staff> query = _context.Staff
                .Include(c => c.Address);

            if (includeRole)
            {
                query = query.Include(c => c.StaffRole);
            }

            // Query It
            query = query.Where(c => c.FirstName == firstname);

            return await query.FirstOrDefaultAsync();
        }

        public async Task<Staff> GetStaffByLastNameAsync(string lastname, bool includeRole = false)
        {
            _logger.LogInformation($"Getting a Staff for {lastname}");

            IQueryable<Staff> query = _context.Staff
                .Include(c => c.Address);

            if (includeRole)
            {
                query = query.Include(c => c.StaffRole);
            }

            // Query It
            query = query.Where(c => c.LastName == lastname);

            return await query.FirstOrDefaultAsync();
        }

        public async Task<Staff> GetStaffByPhoneAsync(string phoneno, bool includeRole = false)
        {
            _logger.LogInformation($"Getting a Staff for {phoneno}");

            IQueryable<Staff> query = _context.Staff
                .Include(c => c.Address);

            if (includeRole)
            {
                query = query.Include(c => c.StaffRole);
            }

            // Query It
            query = query.Where(c => c.PhoneNo == phoneno);

            return await query.FirstOrDefaultAsync();
        }
        public async Task<StaffRole> GetStaffRoleAsync(long staffId)
        {
            _logger.LogInformation($"Getting StaffRole");

            var query = _context.StaffRole
              .Where(t => t.StaffRoleId == staffId);

            return await query.FirstOrDefaultAsync();
        }
        public async Task<ProductDetail> GetProductDetailAsync(long productId)
        {
            _logger.LogInformation($"Getting Product Detail");

            var query = _context.ProductDetail
              .Where(t => t.ProductId == productId);

            return await query.FirstOrDefaultAsync();
        }
        public async Task<Inventory> GetInventoryAsync(long inventoryId)
        {
            _logger.LogInformation($"Getting Inventory");

            var query = _context.Inventory
              .Where(t => t.InventoryId == inventoryId);

            return await query.FirstOrDefaultAsync();
        }
    }
}

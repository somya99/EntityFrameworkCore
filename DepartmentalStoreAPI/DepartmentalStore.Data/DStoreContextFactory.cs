using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DepartmentalStoreAPI.DepartmentalStore.Data
{
    public class DStoreContextFactory : IDesignTimeDbContextFactory<DStoreContext>
    {
        public DStoreContext CreateDbContext(string[] args)
        {
            var config = new ConfigurationBuilder()
              .SetBasePath(Directory.GetCurrentDirectory())
              .AddJsonFile("appsettings.json")
              .Build();

            return new DStoreContext(new DbContextOptionsBuilder<DStoreContext>().Options, config);
        }
    }
}

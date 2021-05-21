using DepartmentalStoreApp.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Store_Console_App
{
    public class Query
    {
        public DepartmentalStoreContext context = new DepartmentalStoreContext();
        public void QueryFilterStaffByName()
        {
            //first name
            var firstname = "Victor";
            var query1 = context.Staff.Where(s => s.FirstName == firstname).ToList();
            foreach(var staff in query1)
            {
                Console.WriteLine($"\n{staff.FirstName}  {staff.LastName}  {staff.PhoneNo}  {staff.Gender}  {staff.Salary}");
            }

            //last name
            var lastname = "Anderson";
            var query2 = context.Staff.Where(s => s.LastName == lastname).ToList();
            foreach (var staff in query2)
            {
                Console.WriteLine($"\n{staff.FirstName}  {staff.LastName}  {staff.PhoneNo}  {staff.Gender}  {staff.Salary}");
            }
        }
        public void QueryFilterStaffByPhoneNo()
        {
            //phone number
            var phoneno = "8248449147";
            var query = context.Staff.Where(s => s.PhoneNo == phoneno).ToList();
            foreach (var staff in query)
            {
                Console.WriteLine($"\n{staff.FirstName}  {staff.LastName}  {staff.PhoneNo}  {staff.Gender}  {staff.Salary}");
            }
        }
        public void QueryFilterStaffByRoleName() // staff join role
        {
            //role name
            Console.WriteLine("For Manager");
            var role1 = "Manager";
            var query1 = context.StaffRole.Include(s => s.Staff).Where(s => s.RoleName == role1).ToList();
            foreach (var staffrole in query1)
            {
                foreach (var staff in staffrole.Staff)
                {
                    Console.WriteLine($"\n{staff.FirstName}  {staff.LastName}  {staff.PhoneNo}  {staff.Gender}  {staff.Salary}");
                }
            }

            Console.WriteLine("For Cashier");
            var role2 = "Cashier";
            var query2 = context.StaffRole.Include(s => s.Staff).Where(s => s.RoleName == role2).ToList();
            foreach (var staffrole in query2)
            {
                foreach (var staff in staffrole.Staff)
                {
                    Console.WriteLine($"\n{staff.FirstName}  {staff.LastName}  {staff.PhoneNo}  {staff.Gender}  {staff.Salary}");
                }
            }

            Console.WriteLine("For Helper");
            var role3 = "Helper";
            var query3 = context.StaffRole.Include(s => s.Staff).Where(s => s.RoleName == role3).ToList();
            foreach (var staffrole in query3)
            {
                foreach (var staff in staffrole.Staff)
                {
                    Console.WriteLine($"\n{staff.FirstName}  {staff.LastName}  {staff.PhoneNo}  {staff.Gender}  {staff.Salary}");
                }
            }
        }
        public void QueryFilterProductByName()
        {
            //product name
            var name = "Foundation";
            var query = context.Product.Where(s => s.ProductName == name).ToList();
            foreach (var product in query)
            {
                Console.WriteLine($"\n{product.ProductName}  {product.ProductCode}  {product.Manufacturer}  {product.CurrentQuantity}");
            }
        }
        public void QueryFilterProductByCategory() // product join category
        {
            //category name
            var category = "Sports";
            var query = context.Product.Include(p => p.ProductCategory).ThenInclude(c => c.Category)
                .Where(c => c.ProductCategory.Any(p => p.Category.CategoryName == category)).ToList();
            foreach(var product in query)
            {
                Console.WriteLine($"\n{product.ProductName}  {product.ProductCode}  {product.Manufacturer}  {product.CurrentQuantity}");
            }
        } 
        public void QueryFilterProductByInStock() // product join inventory
        {
            //in stock
            Console.WriteLine("For InStock");
            var query1 = context.Product.Include(p => p.Inventory).Where(p => p.Inventory.InStock == true).ToList();
            foreach(var product in query1)
            {
                Console.WriteLine($"\n{product.ProductName}  {product.ProductCode}  {product.Manufacturer}  {product.CurrentQuantity} ");
            }

            //out of stock
            Console.WriteLine("For OutOfStock");
            var query2 = context.Product.Include(p => p.Inventory).Where(p => p.Inventory.InStock == false).ToList();
            foreach (var product in query2)
            {
                Console.WriteLine($"\n{product.ProductName}  {product.ProductCode}  {product.Manufacturer}  {product.CurrentQuantity} ");
            }
        }
        public void QueryFilterProductBySellingPrice() //product join product detail
        {
            // selling price less than (<)
            Console.WriteLine("For less than");
            var query1 = context.Product.Include(p => p.ProductDetail).Where(p => p.ProductDetail.SellingPrice < 100).ToList();
            foreach (var product in query1)
            {
                Console.WriteLine($"\n{product.ProductName}  {product.ProductCode}  {product.Manufacturer}  {product.CurrentQuantity} ");
            }

            //selling price greater than (>)
            Console.WriteLine("For greater than");
            var query2 = context.Product.Include(p => p.ProductDetail).Where(p => p.ProductDetail.SellingPrice > 100).ToList();
            foreach (var product in query2)
            {
                Console.WriteLine($"\n{product.ProductName}  {product.ProductCode}  {product.Manufacturer}  {product.CurrentQuantity} ");
            }

            //selling price between
            Console.WriteLine("For between");
            var query3 = context.Product.Include(p => p.ProductDetail).Where(p => p.ProductDetail.SellingPrice > 100 && p.ProductDetail.SellingPrice < 500).ToList();
            foreach (var product in query3)
            {
                Console.WriteLine($"\n{product.ProductName}  {product.ProductCode}  {product.Manufacturer}  {product.CurrentQuantity} ");
            }
        }
        public void NumberOfProductOutOfStock() // product join inventory
        {
            //count of product out of stock
            var query = context.Product.Include(p => p.Inventory).Where(p => p.Inventory.InStock == false).ToList();
            Console.WriteLine($"\n Total number of product out of stock : {query.Count}");
        }
        public void NumberOfProductInACategory() // product join category
        {
            //count of product in a category
            var query = context.Category.Include(c => c.ProductCategory).ThenInclude(p => p.Product)
                .Select(s => new { s.CategoryName, s.ProductCategory.Count }).ToList();
            foreach(var element in query)
            {
                Console.WriteLine($"\n{element.CategoryName}  {element.Count}");
            }
        }
        public void ProductCategoryListCount() // product join category
        {
            //order of product in category in descending order based on count
            var query = context.Category.Include(c => c.ProductCategory).ThenInclude(p => p.Product)
                .Select(s => new { s.CategoryName, s.ProductCategory.Count }).OrderByDescending(a => a.Count).ToList();
            foreach (var element in query)
            {
                Console.WriteLine($"\n{element.CategoryName}  {element.Count}");
            }
        }
        public void QueryFilterSupplierByName()
        {
            //first name
            var firstname = "Gemma";
            var query1 = context.Supplier.Where(s => s.FirstName == firstname).ToList();
            foreach (var supplier in query1)
            {
                Console.WriteLine($"\n{supplier.FirstName}  {supplier.LastName}  {supplier.PhoneNo}  {supplier.Email}  {supplier.City}");
            }

            //last name
            var lastname = "Akerman";
            var query2 = context.Supplier.Where(s => s.LastName == lastname).ToList();
            foreach (var supplier in query2)
            {
                Console.WriteLine($"\n{supplier.FirstName}  {supplier.LastName}  {supplier.PhoneNo}  {supplier.Email}  {supplier.City}");
            }
        }
        public void QueryFilterSupplierByPhoneNo()
        {
            //phone number
            var phoneno = "7386526589";
            var query = context.Supplier.Where(s => s.PhoneNo == phoneno).ToList();
            foreach (var supplier in query)
            {
                Console.WriteLine($"\n{supplier.FirstName}  {supplier.LastName}  {supplier.PhoneNo}  {supplier.Email}  {supplier.City}");
            }
        }
        public void QueryFilterSupplierByEmail()
        {
            //email
            var email = "brian.cox@gmail.com";
            var query = context.Supplier.Where(s => s.Email == email).ToList();
            foreach (var supplier in query)
            {
                Console.WriteLine($"\n{supplier.FirstName}  {supplier.LastName}  {supplier.PhoneNo}  {supplier.Email}  {supplier.City}");
            }
        }
        public void QueryFilterSupplierByCity()
        {
            //city
            var city = "Pune";
            var query = context.Supplier.Where(s => s.City == city).ToList();
            foreach (var supplier in query)
            {
                Console.WriteLine($"\n{supplier.FirstName}  {supplier.LastName}  {supplier.PhoneNo}  {supplier.Email}  {supplier.City}");
            }
        }
        public void QueryFilterSupplyByProductName() //supply join product
        {
            //Product name
            var productname = "Gloves";
            var query = context.Product.Include(s => s.Supply).Where(p => p.ProductName == productname).ToList();
            foreach(var product in query)
            {
                foreach(var supply in product.Supply)
                {
                    Console.WriteLine($"\n{supply.DateOfSupply}  {supply.QuantitySupplied}");
                }
            }
                
        }
        public void QueryFilterSupplyBySupplierName() // supply join supplier
        {
            //supplier first name 
            var firstname = "Marlon";
            var query1 = context.Supplier.Include(s => s.Supply).Where(s => s.FirstName == firstname).ToList();
            foreach (var supplier in query1)
            {
                foreach (var supply in supplier.Supply)
                {
                    Console.WriteLine($"\n{supply.DateOfSupply}  {supply.QuantitySupplied}");
                }
            }

            //supplier last name
            var lastname = "Braga";
            var query2 = context.Supplier.Include(s => s.Supply).Where(s => s.LastName == lastname).ToList();
            foreach (var supplier in query2)
            {
                foreach (var supply in supplier.Supply)
                {
                    Console.WriteLine($"\n{supply.DateOfSupply}  {supply.QuantitySupplied}");
                }
            }
        }
        public void QueryFilterSupplyByProductCode() //supply join product
        {
            //product code
            var productcode = "ELI";
            var query = context.Product.Include(s => s.Supply).Where(p => p.ProductCode == productcode).ToList();
            foreach (var product in query)
            {
                foreach (var supply in product.Supply)
                {
                    Console.WriteLine($"\n{supply.DateOfSupply}  {supply.QuantitySupplied}");
                }
            }
        }
        public void QueryFilterSupplyByDateOfSupply() 
        {
            var date = new DateTime(2021, 03, 08);
            //before date of supply
            Console.WriteLine("For before date");
            var query1 = context.Supply.Where(s => s.DateOfSupply < date).ToList();
            foreach(var supply in query1)
            {
                Console.WriteLine($"\n{supply.DateOfSupply}  {supply.QuantitySupplied}");
            }

            //after date of supply
            Console.WriteLine("For after date");
            var query2 = context.Supply.Where(s => s.DateOfSupply > date).ToList();
            foreach (var supply in query2)
            {
                Console.WriteLine($"\n{supply.DateOfSupply}  {supply.QuantitySupplied}");
            }
        }
        public void QueryFilterSupplyByProductInventory() // supply join product join inventory
        {
            var quantity = 500;
            //inventory less than quantity
            Console.WriteLine("For less than ");
            var query1 = context.Supply.Include(p => p.Product).ThenInclude(p => p.Inventory).Where(p => p.Product.Inventory.TotalQuantity < quantity);
            foreach(var supply in query1)
            {
                Console.WriteLine($"\n{supply.DateOfSupply}  {supply.QuantitySupplied}");
            }

            //inventory greater than quantity
            Console.WriteLine("For greater than ");
            var query2 = context.Supply.Include(p => p.Product).ThenInclude(p => p.Inventory).Where(p => p.Product.Inventory.TotalQuantity > quantity);
            foreach (var supply in query2)
            {
                Console.WriteLine($"\n{supply.DateOfSupply}  {supply.QuantitySupplied}");
            }
        }
    }
}

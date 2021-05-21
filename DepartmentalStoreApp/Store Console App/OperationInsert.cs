using DepartmentalStoreApp.Data;
using DepartmentalStoreApp.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store_Console_App
{
    public class OperationInsert
    {
        public DepartmentalStoreContext context = new DepartmentalStoreContext(); 
        public void InsertValueInAddressTable()
        {
            var address1 = new Address { AddressLine1 = "Plot no.108", AddressLine2 = "Civil Lines", City = "Pune", State = "Maharashtra", Pincode = "263487" };
            var address2 = new Address { AddressLine1 = "House no.432", AddressLine2 = "Gyan Park", City = "Ghaziabad", State = "Uttar Pradesh", Pincode = "366229" };
            var address3 = new Address { AddressLine1 = "House no.210", AddressLine2 = "Stadium Road", City = "Bareilly", State = "Uttar Pradesh", Pincode = "201563" };
            var address4 = new Address { AddressLine1 = "Plot no.325", AddressLine2 = "Sobti Nagar", City = "Gurugram", State = "Haryana", Pincode = "234758" };
            var address5 = new Address { AddressLine1 = "Plot no.652", AddressLine2 = "Janakpuri", City = "Bengaluru", State = "Karnataka", Pincode = "245387" };
            var address6 = new Address { AddressLine1 = "House no.873", AddressLine2 = "Kailash Nagar", City = "Mumbai", State = "Maharashtra", Pincode = "852912" };
            var address7 = new Address { AddressLine1 = "Plot no.328", AddressLine2 = "Indra Puram", City = "Surat", State = "Gujarat", Pincode = "251361" };
            var address8 = new Address { AddressLine1 = "House no.124", AddressLine2 = "Professor Colony", City = "Ranchi", State = "Jharkhand", Pincode = "319632" };
            var address9 = new Address { AddressLine1 = "Plot no.972", AddressLine2 = "Krishna Park", City = "Jaipur", State = "Rajasthan", Pincode = "987221" };
            var address10 = new Address { AddressLine1 = "House no.091", AddressLine2 = "Pari Chowk", City = "Ahmedabad", State = "Gujarat", Pincode = "214253" };

            context.Address.AddRange(address1, address2, address3, address4, address5, address6, address7, address8, address9, address10);
            context.SaveChanges();
        }
        public void InsertValueInStaffRoleTable()
        {
            var role1 = new StaffRole { RoleName = "Manager", Description = "Manage the godown where the stock is piled" };
            var role2 = new StaffRole { RoleName = "Cashier", Description = "Manage at counter to prepare bill and charge" };
            var role3 = new StaffRole { RoleName = "Helper", Description = "Search and collect product based on customer requirement" };

            context.StaffRole.AddRange(role1, role2, role3);
            context.SaveChanges();
        }
        public void InsertValueInStaffTable()
        {
            var staff1 = new Staff { FirstName = "Tomas", LastName = "Alfredson", PhoneNo = "9872351673", Gender = "M", AddressId = 3, StaffRoleId = 1, Salary = 70500 };
            var staff2 = new Staff { FirstName = "Paul", LastName = "Anderson", PhoneNo = "7337342992", Gender = "M", AddressId = 6, StaffRoleId = 3, Salary = 18680 };
            var staff3 = new Staff { FirstName = "Wes", LastName = "Anderue", PhoneNo = "9132614871", Gender = "F", AddressId = 2, StaffRoleId = 1, Salary = 65200 };
            var staff4 = new Staff { FirstName = "Luc", LastName = "Besson", PhoneNo = "8248449147", Gender = "M", AddressId = 7, StaffRoleId = 2, Salary = 25890 };
            var staff5 = new Staff { FirstName = "James", LastName = "Cameron", PhoneNo = "9981477462", Gender = "F", AddressId = 10, StaffRoleId = 2, Salary = 23170 };
            var staff6 = new Staff { FirstName = "Victor", LastName = "Fleming", PhoneNo = "8938743273", Gender = "M", AddressId = 1, StaffRoleId = 3, Salary = 15400 };
            var staff7 = new Staff { FirstName = "Florian", LastName = "Henckel", PhoneNo = "9858726582", Gender = "F", AddressId = 9, StaffRoleId = 1, Salary = 87030 };
            var staff8 = new Staff { FirstName = "Terry", LastName = "Jones", PhoneNo = "8837563257", Gender = "M", AddressId = 4, StaffRoleId = 2, Salary = 24900 };
            var staff9 = new Staff { FirstName = "John", LastName = "Lasseter", PhoneNo = "9872146328", Gender = "M", AddressId = 5, StaffRoleId = 3, Salary = 19205 };
            var staff10 = new Staff { FirstName = "George", LastName = "Lucas", PhoneNo = "8325872982", Gender = "F", AddressId = 8, StaffRoleId = 2, Salary = 22780 };

            context.Staff.AddRange(staff1, staff2, staff3, staff4, staff5, staff6, staff7, staff8, staff9, staff10);
            context.SaveChanges();
        }
        public void InsertValueInCategoryTable()
        {
            var category1 = new Category { CategoryName = "Dairy", Description = "Kitchen Product" };
            var category2 = new Category { CategoryName = "Clothing", Description = "Grooming Product" };
            var category3 = new Category { CategoryName = "Furniture", Description = "Furnishing Product" };
            var category4 = new Category { CategoryName = "Cosmetics", Description = "Grooming Product" };
            var category5 = new Category { CategoryName = "Electric Appliances", Description = "Electrical Product" };
            var category6 = new Category { CategoryName = "Sports", Description = "Activity Product" };
            var category7 = new Category { CategoryName = "Gardening", Description = "Furnishing Product" };
            var category8 = new Category { CategoryName = "Bath products", Description = "Bathroom Product" };
            var category9 = new Category { CategoryName = "Stationary", Description = "Stationary Product" };
            var category10 = new Category { CategoryName = "Food", Description = "Kitchen Product" };

            context.Category.AddRange(category1, category2, category3, category4, category5, category6, category7, category8, category9, category10);
            context.SaveChanges();
        }
        public void InsertValueInProductTable()
        {
            var product1 = new Product { ProductName = "Pen", ProductCode = "PEN", Manufacturer = "Classmate", CurrentQuantity = 1865 };
            var product2 = new Product { ProductName = "Soap", ProductCode = "SOP", Manufacturer = "Dove", CurrentQuantity = 476 };
            var product3 = new Product { ProductName = "Sofa", ProductCode = "SOF", Manufacturer = "Godrej", CurrentQuantity = 30 };
            var product4 = new Product { ProductName = "Bat", ProductCode = "BAT", Manufacturer = "SS", CurrentQuantity = 947 };
            var product5 = new Product { ProductName = "Foundation", ProductCode = "FND", Manufacturer = "Lakme", CurrentQuantity = 143 };
            var product6 = new Product { ProductName = "Shirt", ProductCode = "SRT", Manufacturer = "John Player", CurrentQuantity = 457 };
            var product7 = new Product { ProductName = "Flower Pot", ProductCode = "FRP", Manufacturer = "Ahuja", CurrentQuantity = 54 };
            var product8 = new Product { ProductName = "Shampoo", ProductCode = "SMP", Manufacturer = "Loreal Paris", CurrentQuantity = 6878 };
            var product9 = new Product { ProductName = "Bread", ProductCode = "BRD", Manufacturer = "Britannia", CurrentQuantity = 643 };
            var product10 = new Product { ProductName = "Milk", ProductCode = "MLK", Manufacturer = "Amul", CurrentQuantity = 243 };
            var product11 = new Product { ProductName = "Fan", ProductCode = "FAN", Manufacturer = "Havels", CurrentQuantity = 376 };
            var product12 = new Product { ProductName = "Table", ProductCode = "TBL", Manufacturer = "Nilkamal", CurrentQuantity = 21 };
            var product13 = new Product { ProductName = "Eye Liner", ProductCode = "ELI", Manufacturer = "Sugar", CurrentQuantity = 489 };
            var product14 = new Product { ProductName = "Jeans", ProductCode = "JNS", Manufacturer = "Koty", CurrentQuantity = 135 };
            var product15 = new Product { ProductName = "Notebook", ProductCode = "NTB", Manufacturer = "Cursive", CurrentQuantity = 3657 };
            var product16 = new Product { ProductName = "Football", ProductCode = "FTB", Manufacturer = "Riddell", CurrentQuantity = 10 };
            var product17 = new Product { ProductName = "Gloves", ProductCode = "GLV", Manufacturer = "Atlas", CurrentQuantity = 287 };
            var product18 = new Product { ProductName = "Curd", ProductCode = "CRD", Manufacturer = "Ananda", CurrentQuantity = 3567 };
            var product19 = new Product { ProductName = "Biscuits", ProductCode = "BSC", Manufacturer = "Parle", CurrentQuantity = 4657 };
            var product20 = new Product { ProductName = "Bulb", ProductCode = "BLB", Manufacturer = "Surya", CurrentQuantity = 1347 };
            var product21 = new Product { ProductName = "Marker", ProductCode = "MKR", Manufacturer = "Doms", CurrentQuantity = 1974 };
            var product22 = new Product { ProductName = "Paneer", ProductCode = "PNR", Manufacturer = "Mother Dairy", CurrentQuantity = 28 };
            var product23 = new Product { ProductName = "T-Shirt", ProductCode = "TST", Manufacturer = "Puma", CurrentQuantity = 274 };
            var product24 = new Product { ProductName = "Pencil", ProductCode = "PNC", Manufacturer = "Natraj", CurrentQuantity = 7245 };
            var product25 = new Product { ProductName = "Body Wash", ProductCode = "BWS", Manufacturer = "Biotique", CurrentQuantity = 172 };

            context.Product.AddRange(product1, product2, product3, product4, product5, product6, product7, product8, product9, product10, product11, product12, product13, product14, product15, product16, product17, product18, product19, product20, product21, product22, product23, product24, product25);
            context.SaveChanges();
        }
        public void InsertValueInProductCategoryTable()
        {
            var productcategory1 = new ProductCategory { ProductId = 1, CategoryId = 9};
            var productcategory2 = new ProductCategory { ProductId = 2, CategoryId = 8};
            var productcategory3 = new ProductCategory { ProductId = 3, CategoryId = 3};
            var productcategory4 = new ProductCategory { ProductId = 4, CategoryId = 6};
            var productcategory5 = new ProductCategory { ProductId = 5, CategoryId = 4};
            var productcategory6 = new ProductCategory { ProductId = 6, CategoryId = 2};
            var productcategory7 = new ProductCategory { ProductId = 7, CategoryId = 7};
            var productcategory8 = new ProductCategory { ProductId = 8, CategoryId = 8};
            var productcategory9 = new ProductCategory { ProductId = 9, CategoryId = 10};
            var productcategory10 = new ProductCategory { ProductId = 10, CategoryId = 1};
            var productcategory11 = new ProductCategory { ProductId = 11, CategoryId = 5};
            var productcategory12 = new ProductCategory { ProductId = 12, CategoryId = 3};
            var productcategory13 = new ProductCategory { ProductId = 13, CategoryId = 4};
            var productcategory14 = new ProductCategory { ProductId = 14, CategoryId = 2};
            var productcategory15 = new ProductCategory { ProductId = 15, CategoryId = 9};
            var productcategory16 = new ProductCategory { ProductId = 16, CategoryId = 6};
            var productcategory17 = new ProductCategory { ProductId = 17, CategoryId = 7};
            var productcategory18 = new ProductCategory { ProductId = 18, CategoryId = 1};
            var productcategory19 = new ProductCategory { ProductId = 19, CategoryId = 10};
            var productcategory20 = new ProductCategory { ProductId = 20, CategoryId = 5};
            var productcategory21 = new ProductCategory { ProductId = 21, CategoryId = 9};
            var productcategory22 = new ProductCategory { ProductId = 22, CategoryId = 1};
            var productcategory23 = new ProductCategory { ProductId = 23, CategoryId = 2};
            var productcategory24 = new ProductCategory { ProductId = 24, CategoryId = 9};
            var productcategory25 = new ProductCategory { ProductId = 25, CategoryId = 8};

            context.ProductCategory.AddRange(productcategory1, productcategory2, productcategory3, productcategory4, productcategory5, productcategory6, productcategory7, productcategory8, productcategory9, productcategory10, productcategory11, productcategory12, productcategory13, productcategory14, productcategory15, productcategory16, productcategory17, productcategory18, productcategory19, productcategory20, productcategory21, productcategory22, productcategory23, productcategory24, productcategory25);
            context.SaveChanges();
        }
        public void InsertValueInProductDetailTable()
        {
            var productdetail1 = new ProductDetail { ProductId = 1, CostPrice = 8, SellingPrice = 10, DateOfManufacture =  new DateTime(2020,03,15) };
            var productdetail2 = new ProductDetail { ProductId = 2, CostPrice = 40, SellingPrice = 45, DateOfManufacture = new DateTime(2021,01,19) };
            var productdetail3 = new ProductDetail { ProductId = 3, CostPrice = 1320, SellingPrice = 1580, DateOfManufacture = new DateTime(2020,04,02) };
            var productdetail4 = new ProductDetail { ProductId = 4, CostPrice = 450, SellingPrice = 500, DateOfManufacture = new DateTime(2020,06,30) };
            var productdetail5 = new ProductDetail { ProductId = 5, CostPrice = 200, SellingPrice = 399, DateOfManufacture = new DateTime(2020,09,23) };
            var productdetail6 = new ProductDetail { ProductId = 6, CostPrice = 590, SellingPrice = 699, DateOfManufacture = new DateTime(2019,12,05) };
            var productdetail7 = new ProductDetail { ProductId = 7, CostPrice = 180, SellingPrice = 200, DateOfManufacture = new DateTime(2018,08,26) };
            var productdetail8 = new ProductDetail { ProductId = 8, CostPrice = 459, SellingPrice = 530, DateOfManufacture = new DateTime(2020,05,20) };
            var productdetail9 = new ProductDetail { ProductId = 9, CostPrice = 20, SellingPrice = 25, DateOfManufacture = new DateTime(2021,05,17) };
            var productdetail10 = new ProductDetail { ProductId = 10, CostPrice = 35, SellingPrice = 45, DateOfManufacture = new DateTime(2020,02,14) };
            var productdetail11 = new ProductDetail { ProductId = 11, CostPrice = 390, SellingPrice = 499, DateOfManufacture = new DateTime(2018,11,20) };
            var productdetail12 = new ProductDetail { ProductId = 12, CostPrice = 249, SellingPrice = 350, DateOfManufacture = new DateTime(2020,10,31) };
            var productdetail13 = new ProductDetail { ProductId = 13, CostPrice = 250, SellingPrice = 300, DateOfManufacture = new DateTime(2021,08,02) };
            var productdetail14 = new ProductDetail { ProductId = 14, CostPrice = 890, SellingPrice = 1200, DateOfManufacture = new DateTime(2018,07,07) };
            var productdetail15 = new ProductDetail { ProductId = 15, CostPrice = 120, SellingPrice = 150, DateOfManufacture = new DateTime(2019,03,25) };
            var productdetail16 = new ProductDetail { ProductId = 16, CostPrice = 260, SellingPrice = 320, DateOfManufacture = new DateTime(2021,04,13) };
            var productdetail17 = new ProductDetail { ProductId = 17, CostPrice = 470, SellingPrice = 500, DateOfManufacture = new DateTime(2019,12,18) };
            var productdetail18 = new ProductDetail { ProductId = 18, CostPrice = 21, SellingPrice = 25, DateOfManufacture = new DateTime(2021,05,15) };
            var productdetail19 = new ProductDetail { ProductId = 19, CostPrice = 105, SellingPrice = 130, DateOfManufacture = new DateTime(2020,06,29) };
            var productdetail20 = new ProductDetail { ProductId = 20, CostPrice = 39, SellingPrice = 50, DateOfManufacture = new DateTime(2020,11,11) };
            var productdetail21 = new ProductDetail { ProductId = 21, CostPrice = 40, SellingPrice = 50, DateOfManufacture = new DateTime(2018,02,09) };
            var productdetail22 = new ProductDetail { ProductId = 22, CostPrice = 300, SellingPrice = 360, DateOfManufacture = new DateTime(2021,05,17) };
            var productdetail23 = new ProductDetail { ProductId = 23, CostPrice = 590, SellingPrice = 780, DateOfManufacture = new DateTime(2019,10,04) };
            var productdetail24 = new ProductDetail { ProductId = 24, CostPrice = 10, SellingPrice = 15, DateOfManufacture = new DateTime(2018,09,11) };
            var productdetail25 = new ProductDetail { ProductId = 25, CostPrice = 580, SellingPrice = 600, DateOfManufacture = new DateTime(2020,08,30) };

            context.ProductDetail.AddRange(productdetail1, productdetail2, productdetail3, productdetail4, productdetail5, productdetail6, productdetail7, productdetail8, productdetail9, productdetail10, productdetail11, productdetail12, productdetail13, productdetail14, productdetail15, productdetail16, productdetail17, productdetail18, productdetail19, productdetail20, productdetail21, productdetail22, productdetail23, productdetail24, productdetail25);
            context.SaveChanges();
        }
        public void InsertValueInInventoryTable()
        {
            var inventory1 = new Inventory { ProductId = 1, TotalQuantity = 2864, InStock = true };
            var inventory2 = new Inventory { ProductId = 2, TotalQuantity = 873, InStock = true };
            var inventory3 = new Inventory { ProductId = 3, TotalQuantity = 42, InStock = false };
            var inventory4 = new Inventory { ProductId = 4, TotalQuantity = 1743, InStock = true };
            var inventory5 = new Inventory { ProductId = 5, TotalQuantity = 258, InStock = true };
            var inventory6 = new Inventory { ProductId = 6, TotalQuantity = 985, InStock = true };
            var inventory7 = new Inventory { ProductId = 7, TotalQuantity = 73, InStock = false };
            var inventory8 = new Inventory { ProductId = 8, TotalQuantity = 8964, InStock = true };
            var inventory9 = new Inventory { ProductId = 9, TotalQuantity = 752, InStock = true };
            var inventory10 = new Inventory { ProductId = 10, TotalQuantity = 914, InStock = true };
            var inventory11 = new Inventory { ProductId = 11, TotalQuantity = 521, InStock = true };
            var inventory12 = new Inventory { ProductId = 12, TotalQuantity = 35, InStock = true };
            var inventory13 = new Inventory { ProductId = 13, TotalQuantity = 523, InStock = true };
            var inventory14 = new Inventory { ProductId = 14, TotalQuantity = 298, InStock = true };
            var inventory15 = new Inventory { ProductId = 15, TotalQuantity = 5325, InStock = true };
            var inventory16 = new Inventory { ProductId = 16, TotalQuantity = 18, InStock = false };
            var inventory17 = new Inventory { ProductId = 17, TotalQuantity = 381, InStock = true };
            var inventory18 = new Inventory { ProductId = 18, TotalQuantity = 6847, InStock = true };
            var inventory19 = new Inventory { ProductId = 19, TotalQuantity = 5138, InStock = true };
            var inventory20 = new Inventory { ProductId = 20, TotalQuantity = 2484, InStock = true };
            var inventory21 = new Inventory { ProductId = 21, TotalQuantity = 3525, InStock = true };
            var inventory22 = new Inventory { ProductId = 22, TotalQuantity = 54, InStock = false };
            var inventory23 = new Inventory { ProductId = 23, TotalQuantity = 342, InStock = true };
            var inventory24 = new Inventory { ProductId = 24, TotalQuantity = 9816, InStock = true };
            var inventory25 = new Inventory { ProductId = 25, TotalQuantity = 218, InStock = true };

            context.Inventory.AddRange(inventory1, inventory2, inventory3, inventory4, inventory5, inventory6, inventory7, inventory8, inventory9, inventory10, inventory11, inventory12, inventory13, inventory14, inventory15, inventory16, inventory17, inventory18, inventory19, inventory20, inventory21, inventory22, inventory23, inventory24, inventory25);
            context.SaveChanges();
        }
        public void InsertValueInSupplierTable()
        {
            var supplier1 = new Supplier { FirstName = "Malin", LastName = "Akerman", PhoneNo = "9782355327", Email = "malin.akerman@gmail.com", City = "Delhi" };
            var supplier2 = new Supplier { FirstName = "Tim", LastName = "Allen", PhoneNo = "8912847376", Email = "tim.allen@gmail.com", City = "Pune" };
            var supplier3 = new Supplier { FirstName = "Julie", LastName = "Andrews", PhoneNo = "9832562521", Email = "julie.andrews@gmail.com", City = "Bhopal" };
            var supplier4 = new Supplier { FirstName = "Alice", LastName = "Braga", PhoneNo = "7386526589", Email = "alice.braga@gmail.com", City = "Jaipur" };
            var supplier5 = new Supplier { FirstName = "Marlon", LastName = "Brando", PhoneNo = "9283587126", Email = "marlon.brando@gmail.com", City = "Delhi" };
            var supplier6 = new Supplier { FirstName = "Adrien", LastName = "Brody", PhoneNo = "6587421638", Email = "adrien.brody@gmail.com", City = "Lucknow" };
            var supplier7 = new Supplier { FirstName = "Gemma", LastName = "Chan", PhoneNo = "9164328175", Email = "gemma.chan@gmail.com", City = "Mumbai" };
            var supplier8 = new Supplier { FirstName = "John", LastName = "Cleese", PhoneNo = "8164253815", Email = "john.cleese@gmail.com", City = "Chandigarh" };
            var supplier9 = new Supplier { FirstName = "Abbie", LastName = "Cornish", PhoneNo = "8732587128", Email = "abbie.cornish@gmail.com", City = "Pune" };
            var supplier10 = new Supplier { FirstName = "Brian", LastName = "Cox", PhoneNo = "9833218658", Email = "brian.cox@gmail.com", City = "Jaipur" };

            context.Supplier.AddRange(supplier1, supplier2, supplier3, supplier4, supplier5, supplier6, supplier7, supplier8, supplier9, supplier10);
            context.SaveChanges();
        }
        public void InsertValueInSupplyTable()
        {
            var supply1 = new Supply { ProductId = 2, SupplierId = 5, DateOfSupply = new DateTime(2021,03,19), QuantitySupplied = 432 };
            var supply2 = new Supply { ProductId = 6, SupplierId = 4, DateOfSupply = new DateTime(2021,04,24), QuantitySupplied = 478 };
            var supply3 = new Supply { ProductId = 14, SupplierId = 6, DateOfSupply = new DateTime(2021,03,22), QuantitySupplied = 123 };
            var supply4 = new Supply { ProductId = 9, SupplierId = 3, DateOfSupply = new DateTime(2021,05,17), QuantitySupplied = 421 };
            var supply5 = new Supply { ProductId = 8, SupplierId = 7, DateOfSupply = new DateTime(2021,05,13), QuantitySupplied = 3367 };
            var supply6 = new Supply { ProductId = 13, SupplierId = 9, DateOfSupply = new DateTime(2021,08,30), QuantitySupplied = 234 };
            var supply7 = new Supply { ProductId = 5, SupplierId = 2, DateOfSupply = new DateTime(2021,02,10), QuantitySupplied = 123 };
            var supply8 = new Supply { ProductId = 18, SupplierId = 5, DateOfSupply = new DateTime(2021,05,16), QuantitySupplied = 4357 };
            var supply9 = new Supply { ProductId = 4, SupplierId = 6, DateOfSupply = new DateTime(2021,03,28), QuantitySupplied = 989 };
            var supply10 = new Supply { ProductId = 10, SupplierId = 8, DateOfSupply = new DateTime(2021,04,17), QuantitySupplied = 456 };
            var supply11 = new Supply { ProductId = 11, SupplierId = 1, DateOfSupply = new DateTime(2021,09,12), QuantitySupplied = 258 };
            var supply12 = new Supply { ProductId = 5, SupplierId = 4, DateOfSupply = new DateTime(2021,03,24), QuantitySupplied = 130 };
            var supply13 = new Supply { ProductId = 9, SupplierId = 5, DateOfSupply = new DateTime(2021,05,18), QuantitySupplied = 267 };
            var supply14 = new Supply { ProductId = 17, SupplierId = 10, DateOfSupply = new DateTime(2021,10,05), QuantitySupplied = 145 };
            var supply15 = new Supply { ProductId = 2, SupplierId = 8, DateOfSupply = new DateTime(2021,03,08), QuantitySupplied = 324 };
            var supply16 = new Supply { ProductId = 14, SupplierId = 2, DateOfSupply = new DateTime(2021,04,02), QuantitySupplied = 170 };
            var supply17 = new Supply { ProductId = 20, SupplierId = 3, DateOfSupply = new DateTime(2021,05,05), QuantitySupplied = 1356 };
            var supply18 = new Supply { ProductId = 8, SupplierId = 9, DateOfSupply = new DateTime(2021,02,18), QuantitySupplied = 2456 };
            var supply19 = new Supply { ProductId = 11, SupplierId = 7, DateOfSupply = new DateTime(2021,01,16), QuantitySupplied = 260 };
            var supply20 = new Supply { ProductId = 15, SupplierId = 1, DateOfSupply = new DateTime(2021,06,04), QuantitySupplied = 3988 };
            var supply21 = new Supply { ProductId = 6, SupplierId = 4, DateOfSupply = new DateTime(2021,04,23), QuantitySupplied = 342 };
            var supply22 = new Supply { ProductId = 8, SupplierId = 9, DateOfSupply = new DateTime(2021,05,12), QuantitySupplied = 2345 };
            var supply23 = new Supply { ProductId = 19, SupplierId = 10, DateOfSupply = new DateTime(2021,03,10), QuantitySupplied = 4648 };
            var supply24 = new Supply { ProductId = 13, SupplierId = 5, DateOfSupply = new DateTime(2021,09,23), QuantitySupplied = 270 };
            var supply25 = new Supply { ProductId = 20, SupplierId = 6, DateOfSupply = new DateTime(2021,11,12), QuantitySupplied = 1100 };
            var supply26 = new Supply { ProductId = 1, SupplierId = 3, DateOfSupply = new DateTime(2021,04,26), QuantitySupplied = 1346 };
            var supply27 = new Supply { ProductId = 18, SupplierId = 1, DateOfSupply = new DateTime(2021,06,03), QuantitySupplied = 2460 };
            var supply28 = new Supply { ProductId = 1, SupplierId = 8, DateOfSupply = new DateTime(2021,04,21), QuantitySupplied = 1466 };
            var supply29 = new Supply { ProductId =17 , SupplierId = 9, DateOfSupply = new DateTime(2021,02,12), QuantitySupplied = 220 };
            var supply30 = new Supply { ProductId = 10, SupplierId = 4, DateOfSupply = new DateTime(2021,02,09), QuantitySupplied = 376 };
            var supply31 = new Supply { ProductId = 21, SupplierId = 2, DateOfSupply = new DateTime(2021,04,25), QuantitySupplied = 1246 };
            var supply32 = new Supply { ProductId = 25, SupplierId = 8, DateOfSupply = new DateTime(2021,08,23), QuantitySupplied = 166 };
            var supply33 = new Supply { ProductId = 24, SupplierId = 4, DateOfSupply = new DateTime(2021,06,24), QuantitySupplied = 6546 };
            var supply34 = new Supply { ProductId = 21, SupplierId = 9, DateOfSupply = new DateTime(2021,02,25), QuantitySupplied = 1437 };
            var supply35 = new Supply { ProductId = 23, SupplierId = 3, DateOfSupply = new DateTime(2021,10,15), QuantitySupplied = 276 };
            var supply36 = new Supply { ProductId = 24, SupplierId = 10, DateOfSupply = new DateTime(2021,03,01), QuantitySupplied = 2767 };

            context.Supply.AddRange(supply1, supply2, supply3, supply4, supply5, supply6, supply7, supply8, supply9, supply10, supply11, supply12, supply13, supply14, supply15, supply16, supply17, supply18, supply19, supply20, supply21, supply22, supply23, supply24, supply25, supply26, supply27, supply28, supply29, supply30, supply31, supply32, supply33, supply34, supply35, supply36);
            context.SaveChanges();

        }
        
    }
}

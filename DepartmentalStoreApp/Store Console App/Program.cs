using DepartmentalStoreApp.Domain;
using System;

namespace Store_Console_App
{
    class Program
    {
        static void Main(string[] args)
        {
            OperationInsert op = new OperationInsert();
            //op.InsertValueInAddressTable();
            //op.InsertValueInStaffRoleTable();
            //op.InsertValueInStaffTable();
            //op.InsertValueInCategoryTable();
            //op.InsertValueInProductTable();
            //op.InsertValueInProductDetailTable();
            //op.InsertValueInInventoryTable();
            //op.InsertValueInProductCategoryTable();
            //op.InsertValueInSupplierTable();
            //op.InsertValueInSupplyTable();
            //Console.WriteLine("Data added successfully");

            Query query = new Query();

            query.QueryFilterStaffByName();
            query.QueryFilterStaffByPhoneNo();
            query.QueryFilterProductByName();
            query.QueryFilterSupplierByName();
            query.QueryFilterSupplierByPhoneNo();
            query.QueryFilterSupplierByEmail();
            query.QueryFilterSupplierByCity();
            query.QueryFilterStaffByRoleName();
            query.QueryFilterProductByInStock();
            query.QueryFilterProductBySellingPrice();
            query.NumberOfProductOutOfStock();
            query.QueryFilterSupplyByProductName();
            query.QueryFilterSupplyBySupplierName();
            query.QueryFilterSupplyByProductCode();
            query.QueryFilterSupplyByDateOfSupply();
            query.QueryFilterProductByCategory();
            query.NumberOfProductInACategory();
            query.ProductCategoryListCount();
            query.QueryFilterSupplyByProductInventory();
        }
        
    }
}

using AutoMapper;
using DepartmentalStoreAPI.DepartmentalStore.Domain;
using DepartmentalStoreAPI.DepartmentalStore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DepartmentalStoreAPI.DepartmentalStore.Data
{
    public class DStoreProfile : Profile
    {
        public DStoreProfile()
        {
            //Staff related profiles
            this.CreateMap<Staff, StaffModel>()
              .ReverseMap();
            this.CreateMap<StaffRole, StaffRoleModel>()
              .ReverseMap();
            this.CreateMap<Address, AddressModel>()
              .ReverseMap();

            //Product related profiles
            this.CreateMap<Product, ProductModel>()
              .ReverseMap();
            this.CreateMap<ProductDetail, ProductDetailModel>()
              .ReverseMap();
            this.CreateMap<Inventory, InventoryModel>()
              .ReverseMap();
            
        }
    }
}

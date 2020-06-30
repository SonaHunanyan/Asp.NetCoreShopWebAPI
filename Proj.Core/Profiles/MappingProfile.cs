using AutoMapper;
using Proj.Core.Entities;
using Proj.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proj.Core
{
  public  class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<BrandModel, Brand>()
                .ForMember(x => x.Products, y => y.Ignore());
            CreateMap<Brand, BrandModel>();

            CreateMap<CategoryModel, Category>()
                .ForMember(x => x.Products, y => y.Ignore());
            CreateMap<Category, CategoryModel>();

            CreateMap<CustomerModel, Customer>()
                .ForMember(x => x.Orders, y => y.Ignore());
            CreateMap<Customer, CustomerModel>();

            CreateMap<OrderModel, Order>()
                .ForMember(x => x.Customer, y => y.Ignore())
                .ForMember(x => x.Staff, y => y.Ignore())
                .ForMember(x => x.Store, y => y.Ignore())
                .ForMember(x => x.OrderProducts, y => y.Ignore());
            CreateMap<Order, OrderModel>();

            CreateMap<OrderProductModel, OrderProduct>()
                .ForMember(x => x.Order, y => y.Ignore())
                .ForMember(x => x.Product, y => y.Ignore());
            CreateMap<OrderProduct, OrderProductModel>();

            CreateMap<PositionModel, Position>()
                .ForMember(x => x.Staffs, y => y.Ignore());
            CreateMap<Position, PositionModel>();

            CreateMap<ProductModel, Product>()
                .ForMember(x => x.Category, y => y.Ignore())
                .ForMember(x => x.OrderProducts, y => y.Ignore())
                .ForMember(x => x.Stocks, y => y.Ignore())
                .ForMember(x => x.Brand, y => y.Ignore());
            CreateMap<Product, ProductModel>();

            CreateMap<StaffModel, Staff>()
                .ForMember(x => x.Position, y => y.Ignore())
                .ForMember(x => x.Store, y => y.Ignore())
                .ForMember(x => x.Orders, y => y.Ignore());
            CreateMap<Staff, StaffModel>();

            CreateMap<StockModel, Stock>()
                .ForMember(x => x.Store, y => y.Ignore())
                .ForMember(x => x.Product, y => y.Ignore());
            CreateMap<Stock, StockModel>();

            CreateMap<StoreModel, Store>()
                .ForMember(x => x.Staffs, y => y.Ignore())
                .ForMember(x => x.Orders, y => y.Ignore())
                .ForMember(x => x.Stocks, y => y.Ignore());
            CreateMap<Store, StoreModel>();
            CreateMap<UserModel, User>()
                .ForMember(x => x.Role, y => y.Ignore())
                .ForMember(x => x.IsBlocked, y => y.Ignore())
                .ForMember(x => x.IsDeleted, y => y.Ignore());
            CreateMap<User, UserModel>();

            CreateMap<RoleModel, Role>()
                .ForMember(x => x.Users, y => y.Ignore());
            CreateMap<Role, RoleModel>();


        }
    }
}

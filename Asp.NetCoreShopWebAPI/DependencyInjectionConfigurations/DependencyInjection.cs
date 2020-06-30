using EntityRepositoriesByNetCycle.RepositoryAbstraction;
using Microsoft.Extensions.DependencyInjection;
using Proj.Application;
using Proj.Application.Operations;
using Proj.Core;
using Proj.Core.BllInterfaces;
using Proj.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCoreShopWebAPI
{
    public static class DependencyInjection
    {
        public static void AddBllOperations(this IServiceCollection services)
        {
            foreach(var item in Operations)
            {
                services.Add(new ServiceDescriptor(item.Key, item.Value, ServiceLifetime.Transient));
            }
        }

        public static void AddRepositories(this IServiceCollection services)
        {
            foreach(var item in Repositories)
            {
                services.Add(new ServiceDescriptor(item.Key, item.Value, ServiceLifetime.Transient));
            }
        }
        private static readonly Dictionary<Type, Type> Operations = new Dictionary<Type, Type>
        {
            {typeof(IBrandOperations), typeof(BrandOperations) },
            {typeof(ICategoryOperations), typeof(CategoryOperations) },
            {typeof(ICustomerOperations), typeof(CustomerOperations) },
            {typeof(IOrderOperations), typeof(OrderOperations) },
            {typeof(IOrderProductOperations), typeof(OrderProductOperations) },
            {typeof(IPositionOperations), typeof(PositionOperations) },
            {typeof(IProductOperations), typeof(ProductOperations) },
            {typeof(IStaffOperations), typeof(StaffOperations) },
            {typeof(IStockOperations), typeof(StockOperations) },
            {typeof(IStoreOperations), typeof(StoreOperations) },
            {typeof(IUserOperations), typeof(UserOperations) },
            {typeof(IRoleOperations), typeof(RoleOperations) },
            {typeof(IAuthenticationOperations), typeof(AuthenticationOperations) }
        };
        private static readonly Dictionary<Type, Type> Repositories = new Dictionary<Type, Type>
        {
            {typeof(IRepositoryBase<>), typeof(Repositories<>) }
        };
    }
}

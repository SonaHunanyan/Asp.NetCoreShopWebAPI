using AutoMapper;
using EntityRepositoriesByNetCycle.RepositoryAbstraction;
using Proj.Core.BllInterfaces;
using Proj.Core.Entities;
using Proj.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Proj.Application.Operations
{
    public class OrderProductOperations : IOrderProductOperations
    {
        private readonly IRepositoryBase<OrderProduct> _repository;
        private readonly IMapper _mapper;

        public OrderProductOperations(IRepositoryBase<OrderProduct> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task Add(OrderProductModel model)
        {
            OrderProduct entity = _mapper.Map<OrderProduct>(model);
            _repository.Add(entity);
            await _repository.SaveChangesAsync();
        }

        public async Task Delete(OrderProductModel model)
        {
            OrderProduct entity = _mapper.Map<OrderProduct>(model);
            _repository.Delete(entity);
            await _repository.SaveChangesAsync();
        }

        public async Task Delete(int orderId, int productId)
        {
            OrderProduct entity = await _repository.FirstOrdDefaultAsync(x => x.OrderId == orderId && x.ProductId == productId);
            _repository.Delete(entity);
            await _repository.SaveChangesAsync();
        }

        public async Task<OrderProductModel> Get(int orderId, int productId)
        {
            OrderProduct entity = await _repository.FirstOrdDefaultAsync(x => x.OrderId == orderId && x.ProductId == productId);
            OrderProductModel model = _mapper.Map<OrderProductModel>(entity);
            return model;
        }

        public async Task Update(OrderProductModel model)
        {
            OrderProduct entity = _mapper.Map<OrderProduct>(model);
            _repository.Update(entity);
            await _repository.SaveChangesAsync();
        }
    }
}

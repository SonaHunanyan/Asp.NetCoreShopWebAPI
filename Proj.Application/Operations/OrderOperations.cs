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
    public class OrderOperations : IOrderOperations
    {
        private readonly IRepositoryBase<Order> _repository;
        private readonly IMapper _mapper;

        public OrderOperations(IRepositoryBase<Order> repository, IMapper mapper)
        {
            _repository = repository;

            _mapper = mapper;
        }
        public async Task Add(OrderModel model)
        {
            Order entity = _mapper.Map<Order>(model);
            _repository.Add(entity);
            await _repository.SaveChangesAsync();
        }

        public async Task Delete(OrderModel model)
        {
            Order entity = _mapper.Map<Order>(model);
            _repository.Delete(entity);
            await _repository.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            Order entity = await _repository.FirstOrdDefaultAsync(x => x.Id == id);
            _repository.Delete(entity);
            await _repository.SaveChangesAsync();
        }

        public async Task<OrderModel> Get(int id)
        {
            Order entity = await _repository.FirstOrdDefaultAsync(x => x.Id == id);
            OrderModel model = _mapper.Map<OrderModel>(entity);
            return model;
        }

        public async Task Update(OrderModel model)
        {
            Order entity = _mapper.Map<Order>(model);
            _repository.Update(entity);
            await _repository.SaveChangesAsync();
        }
    }
}

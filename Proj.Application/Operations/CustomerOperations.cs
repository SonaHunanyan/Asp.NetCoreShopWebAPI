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
    public class CustomerOperations : ICustomerOperations
    {
        private readonly IRepositoryBase<Customer> _repository;
        private readonly IMapper _mapper;
        public CustomerOperations(IRepositoryBase<Customer> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task Add(CustomerModel model)
        {
            Customer entity = _mapper.Map<Customer>(model);
            _repository.Add(entity);
            await _repository.SaveChangesAsync();
        }

        public async Task Delete(CustomerModel model)
        {
            Customer entity = _mapper.Map<Customer>(model);
            _repository.Delete(entity);
            await _repository.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            Customer entity = await _repository.FirstOrdDefaultAsync(x => x.Id == id);
            _repository.Delete(entity);
            await _repository.SaveChangesAsync();
        }

        public async Task<CustomerModel> Get(int id)
        {
            Customer entity = await _repository.FirstOrdDefaultAsync(x => x.Id == id);
            CustomerModel model = _mapper.Map<CustomerModel>(entity);
            return model;
        }

        public async Task Update(CustomerModel model)
        {
            Customer entity = _mapper.Map<Customer>(model);
            _repository.Update(entity);
            await _repository.SaveChangesAsync();
        }
    }
}

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
   public class StoreOperations : IStoreOperations
    {
        private readonly IRepositoryBase<Store> _repository;
        private readonly IMapper _mapper;

        public StoreOperations(IRepositoryBase<Store> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task Add(StoreModel model)
        {
            Store entity = _mapper.Map<Store>(model);
            _repository.Add(entity);
            await _repository.SaveChangesAsync();
        }

        public async Task Delete(StoreModel model)
        {
            Store entity = _mapper.Map<Store>(model);
            _repository.Delete(entity);
            await _repository.SaveChangesAsync();
        }

        public async Task Delete(int storeId)
        {
            Store entity = await _repository.FirstOrdDefaultAsync(x => x.Id == storeId);
            _repository.Delete(entity);
            await _repository.SaveChangesAsync();

        }

        public async Task<StoreModel> Get(int id)
        {
            Store entity = await _repository.FirstOrdDefaultAsync(x => x.Id == id);
            StoreModel model = _mapper.Map<StoreModel>(entity);
            return model;
                
        }

        public async Task Update(StoreModel model)
        {
            Store entity = _mapper.Map<Store>(model);
            _repository.Update(entity);
            await _repository.SaveChangesAsync();
        }
    }
}

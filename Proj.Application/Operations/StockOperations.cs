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
    public class StockOperations : IStockOperations
    {
        private readonly IRepositoryBase<Stock> _repository;
        private readonly IMapper _mapper;
        public StockOperations(IRepositoryBase<Stock> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task Add(StockModel model)
        {
            Stock entity = _mapper.Map<Stock>(model);
            _repository.Add(entity);
            await _repository.SaveChangesAsync();
        }

        public async Task Delete(StockModel model)
        {
            Stock entity = _mapper.Map<Stock>(model);
            _repository.Delete(entity);
            await _repository.SaveChangesAsync();
        }

        public async Task Delete(int productId, int storeId)
        {
            Stock entity = await _repository.FirstOrdDefaultAsync(x => x.ProductId == productId && x.StoreId == storeId);
            _repository.Delete(entity);
            await _repository.SaveChangesAsync();
        }

        public async Task<StockModel> Get(int productId, int storeId)
        {
            Stock entity = await _repository.FirstOrdDefaultAsync(x => x.ProductId == productId && x.StoreId == storeId);
            StockModel model = _mapper.Map<StockModel>(entity);
            return model;
        }

        public async Task Update(StockModel model)
        {
            Stock entity = _mapper.Map<Stock>(model);
            _repository.Update(entity);
            await _repository.SaveChangesAsync();
        }
    }
}

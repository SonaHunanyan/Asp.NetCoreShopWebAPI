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
    public class ProductOperations : IProductOperations
    {
        private readonly IRepositoryBase<Product> _repository;
        private readonly IMapper _mapper;

        public ProductOperations(IRepositoryBase<Product> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task Add(ProductModel model)
        {
            Product entity = _mapper.Map<Product>(model);
            _repository.Add(entity);
            await _repository.SaveChangesAsync();
        }

        public async Task Delete(ProductModel model)
        {
            Product entity = _mapper.Map<Product>(model);
            _repository.Delete(entity);
            await _repository.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            Product entity = await _repository.FirstOrdDefaultAsync(x => x.Id == id);
            _repository.Delete(entity);
            await _repository.SaveChangesAsync();
        }

        public async Task<ProductModel> Get(int id)
        {
            Product entity = await _repository.FirstOrdDefaultAsync(x => x.Id == id);
            ProductModel model = _mapper.Map<ProductModel>(entity);
            return model;
        }

        public async Task Update(ProductModel model)
        {
            Product entity = _mapper.Map<Product>(model);
            _repository.Update(entity);
            await _repository.SaveChangesAsync();
        }
    }
}

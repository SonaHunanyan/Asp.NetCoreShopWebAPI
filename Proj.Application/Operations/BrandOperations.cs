using AutoMapper;
using EntityRepositoriesByNetCycle.RepositoryAbstraction;
using Proj.Core;
using Proj.Core.Entities;
using System;
using System.Threading.Tasks;

namespace Proj.Application
{
    public class BrandOperations : IBrandOperations
    {
        private readonly IRepositoryBase<Brand> _repository;
        private readonly IMapper _mapper;

        public BrandOperations(IRepositoryBase<Brand> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task Add(BrandModel model)
        {
            Brand entity = _mapper.Map<Brand>(model);
            _repository.Add(entity);
            await _repository.SaveChangesAsync();

        }

        public async Task Delete(BrandModel model)
        {
            Brand entity = _mapper.Map<Brand>(model);
            _repository.Delete(entity);
            await _repository.SaveChangesAsync();

        }

        public async Task Delete(int id)
        {
            Brand entity = await _repository.FirstOrdDefaultAsync(x => x.Id == id);
            _repository.Delete(entity);
            await _repository.SaveChangesAsync();
        }

        public async Task<BrandModel> Get(int id)
        {
            Brand entity = await _repository.FirstOrdDefaultAsync(x => x.Id == id);
            BrandModel model = _mapper.Map<BrandModel>(entity);
            return model;
        }

        public async Task Update(BrandModel model)
        {
            Brand entity = _mapper.Map<Brand>(model);
            _repository.Update(entity);
            await _repository.SaveChangesAsync();
        }
    }
}

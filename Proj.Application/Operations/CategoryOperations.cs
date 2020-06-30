using AutoMapper;
using EntityRepositoriesByNetCycle.RepositoryAbstraction;
using Proj.Core;
using Proj.Core.BllInterfaces;
using Proj.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Proj.Application.Operations
{
    public class CategoryOperations : ICategoryOperations
    {
        private readonly IRepositoryBase<Category> _repository;
        private readonly IMapper _mapper;
        public CategoryOperations(IRepositoryBase<Category> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task Add(CategoryModel model)
        {
            Category entity = _mapper.Map<Category>(model);
            _repository.Add(entity);
            await _repository.SaveChangesAsync();
        }

        public async Task Delete(CategoryModel model)
        {
            Category entity = _mapper.Map<Category>(model);
            _repository.Delete(entity);
            await _repository.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            Category entity =await _repository.FirstOrdDefaultAsync(x =>x.Id == id);
            _repository.Delete(entity);
            await _repository.SaveChangesAsync();
        }

        public async Task<CategoryModel> Get(int id)
        {
            Category entity = await _repository.FirstOrdDefaultAsync(x => x.Id == id);
            CategoryModel model = _mapper.Map<CategoryModel>(entity);
            return model;
        }

        public async Task Update(CategoryModel model)
        {
            Category entity = _mapper.Map<Category>(model);
            _repository.Update(entity);
            await _repository.SaveChangesAsync();
        }
    }
}

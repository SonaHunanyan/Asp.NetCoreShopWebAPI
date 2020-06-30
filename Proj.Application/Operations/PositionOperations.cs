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
    public class PositionOperations : IPositionOperations
    {
        private readonly IRepositoryBase<Position> _repository;
        private readonly IMapper _mapper;
        public PositionOperations(IRepositoryBase<Position> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task Add(PositionModel model)
        {
            Position entity = _mapper.Map<Position>(model);
            _repository.Add(entity);
            await _repository.SaveChangesAsync();
        }

        public async Task Delete(PositionModel model)
        {
            Position entity = _mapper.Map<Position>(model);
            _repository.Delete(entity);
            await _repository.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            Position entity = await _repository.FirstOrdDefaultAsync(x => x.Id == id);
            _repository.Delete(entity);
            await _repository.SaveChangesAsync();
        }

        public async Task<PositionModel> Get(int id)
        {
            Position entity = await _repository.FirstOrdDefaultAsync(x => x.Id == id);
            PositionModel model = _mapper.Map<PositionModel>(entity);
            return model;
        }

        public async Task Update(PositionModel model)
        {
            Position entity = _mapper.Map<Position>(model);
            _repository.Update(entity);
            await _repository.SaveChangesAsync();
        }
    }
}

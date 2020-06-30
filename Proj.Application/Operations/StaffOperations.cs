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
    public class StaffOperations : IStaffOperations
    {
        private readonly IRepositoryBase<Staff> _repository;
        private readonly IMapper _mapper;

        public StaffOperations(IRepositoryBase<Staff> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task Add(StaffModel model)
        {
            Staff entity = _mapper.Map<Staff>(model);
            _repository.Add(entity);
            await _repository.SaveChangesAsync();
        }

        public async Task Delete(StaffModel model)
        {
            Staff entity = _mapper.Map<Staff>(model);
            _repository.Delete(entity);
            await _repository.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            Staff entity = await _repository.FirstOrdDefaultAsync(x => x.Id == id);
            _repository.Delete(entity);
            await _repository.SaveChangesAsync();
        }

        public async Task<StaffModel> Get(int id)
        {
            Staff entity = await _repository.FirstOrdDefaultAsync(x => x.Id == id);
            StaffModel model = _mapper.Map<StaffModel>(entity);
            return model;
        }

        public async Task Update(StaffModel model)
        {
            Staff entity = _mapper.Map<Staff>(model);
            _repository.Update(entity);
            await _repository.SaveChangesAsync();
        }
    }
}

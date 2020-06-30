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
    public class RoleOperations : IRoleOperations
    {
        private readonly IRepositoryBase<Role> _repository;
        private readonly IMapper _mapper;
        public RoleOperations(IRepositoryBase<Role> repository, IMapper mapper)
        {
            _repository = repository;

            _mapper = mapper;
        }
        public async Task Add(RoleModel model)
        {
            Role entity = _mapper.Map<Role>(model);
            _repository.Add(entity);
            await _repository.SaveChangesAsync();
        }

        public async Task Delete(RoleModel model)
        {
            Role entity = _mapper.Map<Role>(model);
            _repository.Delete(entity);
            await _repository.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            Role entity = await _repository.FirstOrdDefaultAsync(x => x.Id == id);
            _repository.Delete(entity);
            _repository.SaveChangesAsync();
        }

        public async Task<RoleModel> Get(int id)
        {
            Role entity = await _repository.FirstOrdDefaultAsync(x => x.Id == id);
            RoleModel model = _mapper.Map<RoleModel>(entity);
            return model;
        }

        public async Task Update(RoleModel model)
        {
            Role entity = _mapper.Map<Role>(model);
            _repository.Update(entity);
            await _repository.SaveChangesAsync();
        }
    }
}

using AutoMapper;
using EntityRepositoriesByNetCycle.RepositoryAbstraction;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Proj.Core.BllInterfaces;
using Proj.Core.Entities;
using Proj.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Proj.Application.Operations
{
    public class UserOperations : IUserOperations
    {
        private readonly IRepositoryBase<User> _repository;
        private readonly IMapper _mapper;
        public UserOperations(IRepositoryBase<User> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task Add(UserModel model)
        {
           model = Validate(model);
  
            model.Password =PasswordHashHelper.GetHashString(model.Password);
            User entity = _mapper.Map<User>(model);
            _repository.Add(entity);
            await _repository.SaveChangesAsync();
        }

        public async Task Delete(UserModel model)
        {
            User entity = _mapper.Map<User>(model);
            _repository.Delete(entity);
            await _repository.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            User entity = await _repository.FirstOrdDefaultAsync(x => x.Id == id);
            _repository.Delete(entity);
            await _repository.SaveChangesAsync();
        }

        public async Task<UserModel> Get(int id)
        {
            User entity = await _repository.FirstOrdDefaultAsync(x => x.Id == id);
            UserModel model = _mapper.Map<UserModel>(entity);
            return model;
        }

        public async Task Update(UserModel model)
        {
            User entity = _mapper.Map<User>(model);
            _repository.Update(entity);
            await _repository.SaveChangesAsync();
        }

        private UserModel Validate(UserModel model)
        {
            bool IsNull = string.IsNullOrEmpty(model.UserName);
            if (IsNull)
                throw new System.Exception("User Name is NOT correct");

            model.Email = model.Email.ToLower();
            model.UserName = model.UserName.ToLower();
            model.UserName = model.UserName.Trim().Replace(" ", "");
            return model;
        }
    }
}

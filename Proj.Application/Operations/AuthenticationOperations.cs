using EntityRepositoriesByNetCycle.RepositoryAbstraction;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Proj.Core.BllInterfaces;
using Proj.Core.Entities;
using Proj.Core.Models;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using System.Threading.Tasks;
using Proj.Core;
using Key = Proj.Core.Key;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;

namespace Proj.Application.Operations
{
    public class AuthenticationOperations : IAuthenticationOperations
    {
        private readonly IRepositoryBase<User> repository;
        public AuthenticationOperations(IRepositoryBase<User> repository)
        {
            this.repository = repository;
        }
        public async Task<string> Authentication(LoginModel loginModel)
        {
            User user = await repository.FirstOrdDefaultAsync(x => x.UserName == loginModel.UserName
                                     && !x.IsBlocked && !x.IsDeleted
                                     && x.Password == PasswordHashHelper.GetHashString(loginModel.Password));
            if(user==null)
            {
                throw new Exception("Acces is denied");
            }

            string token = TokenGenerator(user);
            return token;
        }
        private string TokenGenerator(User user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            byte[] byteKey = Encoding.UTF8.GetBytes(Key.MyKey());
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject=new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimsIdentity.DefaultNameClaimType, user.UserName),
                    new Claim(ClaimsIdentity.DefaultRoleClaimType, user.RoleId.ToString())
                }),
                Audience="Hello",
                Issuer="Hello",
                SigningCredentials=new SigningCredentials(new SymmetricSecurityKey(byteKey),SecurityAlgorithms.HmacSha256Signature),
                IssuedAt=DateTime.UtcNow.AddMinutes(25)

            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenString = tokenHandler.WriteToken(token);
            return tokenString;
        }
    }
}

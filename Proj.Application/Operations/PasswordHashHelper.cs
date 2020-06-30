using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Proj.Application.Operations
{
  public static  class PasswordHashHelper
    {
        private static byte[] GetHash(string password)
        {
            HashAlgorithm algorithm = SHA1.Create();
            return algorithm.ComputeHash(Encoding.UTF8.GetBytes(password));

        }
        public static string GetHashString(string password)
        {
            StringBuilder builder = new StringBuilder();
            foreach(byte item in GetHash(password))
            {
                builder.Append(item.ToString("X2"));

            }
           
            return builder.ToString();
        }
    }
}

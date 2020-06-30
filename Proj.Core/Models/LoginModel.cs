using System;
using System.Collections.Generic;
using System.Text;

namespace Proj.Core.Models
{
  public  class LoginModel
    {
        private string _userName;
        private string _password;

        public string UserName
        {
            get { return _userName; }
            set
            {
                if (value != null && !string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value))
                    _userName = value;
            }
        }
        public string Password
        {
            get { return _password; }
            set
            {
                if (value != null && !string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value))
                    _password = value;
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sberbank
{
    public class CheckUser
    {
        public string Login{ get; set; }
        public bool IsAdmin { get;}

        public string Status => IsAdmin ? "Admin " : "User";

        public CheckUser(String  login, bool isAdmin)
        {
            Login = login.Trim();
            IsAdmin = isAdmin;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Repositories;
using UserModel;

namespace Services
{
    public class LoginService : ILoginService
    {

        ILoginRepo lr;

        public LoginService(ILoginRepo lr)
        {
            this.lr = lr;
        }
        public User Login(Login l)
        {
            return lr.Login(l);
        }

    }
    }

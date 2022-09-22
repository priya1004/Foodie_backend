using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserModel;

namespace Repositories
{
    public class LoginRepo : ILoginRepo
    {
        private readonly LoginContext lc;
        public LoginRepo(LoginContext ac)
        {
            lc = ac;

        }
        public User Login(Login l)
        {
           
            List<User> rr = lc.Users.ToList<User>();
            User u=null;
          
            for(int i=0;i<rr.Count;i++)
            {
                if(rr[i].email == l.email && rr[i].password==l.password)
                {
                    u = rr[i];
                   
                }

            }
            return u;


        }

    }
}

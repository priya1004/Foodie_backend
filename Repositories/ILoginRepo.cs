using Models;
using UserModel;

namespace Repositories
{
    public interface ILoginRepo
    {
        User Login(Login l);
    }
}
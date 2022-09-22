using Models;
using UserModel;

namespace Services

{
    public interface ILoginService
    {
        User Login(Login l);
    }
}
using UserService.Controllers.Models;

namespace UserService.Repositories
{
    public interface IUserRepository
    {
        List<User> Users { get; }

        bool AddUser(UserService );
        bool ValidateUser(User u);
    }
}
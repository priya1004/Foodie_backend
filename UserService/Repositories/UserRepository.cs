using UserService.Controllers.Models;

namespace UserService.Repositories // functions for storijng data to db
{
    public class UserRepository : IUserRepository
    {

        public bool AddUser(UserService)
        {
            return false;
        }
        public bool ValidateUser(User u)
        static List<User> _users = new List<User>() { };
        public List<User> Users
        {
            get { return _users; }
        }








    }
}

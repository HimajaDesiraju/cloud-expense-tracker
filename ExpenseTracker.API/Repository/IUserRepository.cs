using System;
using Models;
namespace Repository{
    public interface IUserRepository{
        bool AddUser(User userdata);
        bool UpdateUser(User userdata);
        bool DeleteUser(string UserId);
        IList<User> GetUsers();
        User GetUserById(string UserId);
    }
}
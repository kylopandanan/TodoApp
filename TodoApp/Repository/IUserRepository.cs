using TodoApp.Models;

namespace TodoApp.Repository
{
    public interface IUserRepository
    {
        //abstract method

        List<User> GetAllUsers();

        User GetUserById(int Id);

        User AddUser(User newUser);

        User UpdateUser(int userId, User newUser);

        User DeleteUser(int userId);

    }
}

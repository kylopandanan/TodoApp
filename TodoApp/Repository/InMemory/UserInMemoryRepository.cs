using TodoApp.Models;

namespace TodoApp.Repository.InMemory
{
    public class UserInMemoryRepository : IUserRepository { 

        static List<User> userList = new List<User>();

        static UserInMemoryRepository()
        {
            userList.Add(new User(1, "Kylo Pandanan", "Gmail.com", "Password", false));
            userList.Add(new User(2, "JJ Coligado", "Ymail.com", "Password123", false));
            userList.Add(new User(3, "Optimum pride", "mail.com", "Password456", false));

        }
        public List<User> GetAllUsers()
        {
            return userList;
        }

        public User GetUserById(int Id)
        {
            return userList.FirstOrDefault(x => x.Id == Id);
        }

        public User AddUser(User newUser)
        {
            newUser.Id = userList.Max(x =>x.Id) + 1; 
            userList.Add(newUser);
            return newUser;
        }

        public User UpdateUser(int userId, User newUser)
        {
            var oldUser = userList.Find(x => x.Id == userId);
            if (oldUser == null)
                return null;
            userList.Remove(oldUser);
            userList.Add(newUser);
            return newUser;
        }
 
        public User DeleteUser(int userId)
        {
            var oldUser = userList.Find(x => x.Id == userId);
            if (oldUser == null)
                return null;
            userList.Remove(oldUser);
            return oldUser;
        }
    }
}

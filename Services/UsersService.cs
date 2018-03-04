using System.Collections.Generic;
using DotNetServer.Models;

namespace DotNetServer.Services
{
    public class UserLocalService : IUserService
    {
        public List<User> List { get; }
        
        public UserLocalService(UserStore store) {
            List = store.List;
        }

        public User Find(int id)
        {
            return List.Find((user) => user.ID == id);
        }
        public User Create(User user)
        {
            List.Add(user);
            return user;
        }

        public int Delete(int id)
        {
            bool success = List.Remove(this.Find(id));
            return success ? id : 0;
        }

        public User Update(User user)
        {
            User _user = this.Find(user.ID);
            int index = List.IndexOf(_user);
            List.RemoveAt(index);
            List.Insert(index, _user);
            return _user;
        }
    }
}
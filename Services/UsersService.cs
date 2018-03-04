using System.Collections.Generic;
using DotNetServer.Models;

namespace DotNetServer.Services
{
    public class UserLocalService : IUserService
    {
        public List<UserModel> List { get; private set; }

        public UserModel Find(int id)
        {
            return List.Find((user) => user.ID == id);
        }
        public UserModel Create(UserModel user)
        {
            List.Add(user);
            return user;
        }

        public int Delete(int id)
        {
            bool success = List.Remove(this.Find(id));
            return success ? id : 0;
        }

        public UserModel Update(UserModel user)
        {
            UserModel _user = this.Find(user.ID);
            int index = List.IndexOf(_user);
            List.RemoveAt(index);
            List.Insert(index, _user);
            return _user;
        }
    }
}
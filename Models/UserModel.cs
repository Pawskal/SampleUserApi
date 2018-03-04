using System;

namespace DotNetServer.Models
{
    public class UserModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int ID { get; }
        public UserModel(string name, string email){
            Name = name;
            Email = email;
            ID = new Random().Next();
        }
    }
}
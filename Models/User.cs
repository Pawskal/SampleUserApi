using System;

namespace DotNetServer.Models
{
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int ID { get; set; }
        // public UserModel(string name, string email){
        //     Name = name;
        //     Email = email;
        //     ID = new Random().Next();
        // }
    }
}
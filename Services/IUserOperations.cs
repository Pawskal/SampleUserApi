using System;
using System.Collections.Generic;
using DotNetServer.Models;

namespace DotNetServer.Services
{
    public interface IUserService
    {
        List<User> List { get; }
        User Find(int id);
        User Create(User user);
        User Update(User user);
        int Delete(int id);
        
    }
}
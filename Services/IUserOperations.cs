using System;
using System.Collections.Generic;
using DotNetServer.Models;

namespace DotNetServer.Services
{
    public interface IUserService
    {
        UserModel Find(int id);
        UserModel Create(UserModel user);
        UserModel Update(UserModel user);
        int Delete(int id);
        
    }
}
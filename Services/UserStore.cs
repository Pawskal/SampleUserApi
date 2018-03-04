using System;
using System.Collections.Generic;
using DotNetServer.Models;
using Bogus;


namespace DotNetServer.Services
{
    public class UserStore
    {
        public List<User> List { get; }
        
        public UserStore(FakeUserGenerator fakeUserService){
            List = new List<User>();

            for (int i = 0; i < 10; i++) {
                List.Add(fakeUserService.fakeUser.Generate());
            }
        }
    }
}
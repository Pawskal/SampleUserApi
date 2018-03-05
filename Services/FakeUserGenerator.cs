using System;
using Bogus;
using SampleUserApi.Models;

namespace SampleUserApi.Services
{
    public class FakeUserService
    {
        public Faker<User> fakeUser { get; private set; }
        public FakeUserService(){
            fakeUser = new Faker<User>()
                .RuleFor(user => user.UserName, faker => faker.Name.FirstName())
                .RuleFor(user => user.Email, faker => faker.Internet.Email())
                .FinishWith((f, u) => {
                    Console.WriteLine("User Created! Id={0}", u.Email);
                });
        }
    }
}
using System;
using Bogus;
using DotNetServer.Models;

namespace DotNetServer.Services
{
    public class FakeUserGenerator
    {
        public Faker<User> fakeUser { get; private set; }
        public Random random;
        public FakeUserGenerator(){
            random = new Random();
            fakeUser = new Faker<User>()
                .RuleFor(user => user.Name, faker => faker.Name.FirstName())
                .RuleFor(user => user.Email, faker => faker.Internet.Email())
                .RuleFor(user => user.ID, faker => random.Next())
                .FinishWith((f, u) => {
                    Console.WriteLine("User Created! Id={0}", u.ID);
                });
        }
    }
}
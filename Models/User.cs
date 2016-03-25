using System;
namespace BasicBeerForms.Models
{
    public class User
    {
        public User()
        {
        }

        public string Name { get; set;}
        public string Location { get; set;}
        public int BeersConsumed { get; set;}
        public string EmailAddress { get; set;}
        public int FriendsCount { get; set;}
    }
}


using System;
namespace BasicBeerForms.MockData
{
    public class UserProfileDataSource
    {
        public UserProfileDataSource()
        {
        }

        public Models.User GetUser()
        {
            var user = new Models.User
            {
                Name = "Mike James",
                Location = "London, England",
                BeersConsumed = 1024,
                EmailAddress = "mike@xamarin.com",
                FriendsCount = 104
            };

            return user;
        }
    }
}


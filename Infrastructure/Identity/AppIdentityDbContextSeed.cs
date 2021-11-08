using System.Linq;
using System.Threading.Tasks;
using Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUsersAsync(UserManager<AppUser> userManager)
        {
            if(!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName="Bob",
                    Email="bob@test.com",
                    UserName="bob1",
                    Address = new Address
                    {
                        FirstName="Bob",
                        LastName="Marley",
                        Street="10 The Street",
                        City="New York",
                        State="NY",
                        ZipCode="902010"
                    }
                };

                await userManager.CreateAsync(user,"Pa$$w0rd");
            }
        }
    }
}
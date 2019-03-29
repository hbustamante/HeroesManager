using DataLayer.Model;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DbInitializer
    {
        public static async Task Seed(IApplicationBuilder applicationBuilder)
        {
            HeroDbContext context = applicationBuilder.ApplicationServices.GetRequiredService<HeroDbContext>();

            UserManager<IdentityUser> userManager = applicationBuilder.ApplicationServices.GetRequiredService<UserManager<IdentityUser>>();
            var user = new IdentityUser("Heber Bustamante");
            await userManager.CreateAsync(user, "%Heb");

            // Add Houses
            var dc = new House { Name = "DC" };
            var marvel = new House { Name = "Marvel" };
            context.Houses.Add(dc);
            context.Houses.Add(marvel);

            // Add Author
            var powerForce = new Power
            {
                Name = "Force",
                Heroes = new List<Hero>()
                {
                    new Hero { Name = "Hulk" },
                    new Hero { Name = "Silver Surfer" }
                }
            };

            var powerVelocity = new Power
            {
                Name = "Velocity",
                Heroes = new List<Hero>()
                {
                    new Hero { Name = "Superman"},
                    new Hero { Name = "Flash"}
                }
            };

            context.Powers.Add(powerForce);
            context.Powers.Add(powerVelocity);

            context.SaveChanges();
        }
    }
}

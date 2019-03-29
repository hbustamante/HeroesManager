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

            var user = new IdentityUser("Heber");
            await userManager.CreateAsync(user, "%Heber");

            // Add House
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

            var authorCardone = new Author
            {
                Name = "Grant Cardone",
                Books = new List<Book>()
                {
                    new Book { Title = "The 10X Rule"},
                    new Book { Title = "If You're Not First, You're Last"},
                    new Book { Title = "Sell To Survive"}
                }
            };

            context.Authors.Add(authorDeMarco);
            context.Authors.Add(authorCardone);

            context.SaveChanges();
        }
    }
}

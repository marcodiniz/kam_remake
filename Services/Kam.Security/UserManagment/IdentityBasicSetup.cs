using System;
using System.Threading.Tasks;
using Kam.Domain.Models;
using Microsoft.AspNet.Identity;
using Microsoft.Framework.DependencyInjection;

namespace Kam.Security.UserManagment
{
    public class IdentityBasicSetup
    {
        public static async Task SetupDefaultUserAndRoles(IServiceProvider serviceProvider)
        {
            var userManager = serviceProvider.GetRequiredService<UserManager<AppUser>>();
            var roleManager= serviceProvider.GetRequiredService<RoleManager<AppRole>>();

            var username = "admin";
            var pass = "12345";
            var adminRole = "admin";

            if (! await roleManager.RoleExistsAsync(adminRole))
            {
                var result = await roleManager.CreateAsync(new AppRole(adminRole));
            }

            var user = await userManager.FindByNameAsync(username);
            if (user == null)
            {
                user = new AppUser() {UserName = username};
                var result = await userManager.CreateAsync(user, pass);
                if (result.Succeeded)
                {
                    var roleResult = await userManager.AddToRoleAsync(user, adminRole);
                }
            }

        }
    }
}
using System;
using System.Threading.Tasks;
using Kam.Domain.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Framework.DependencyInjection;

namespace Kam.Security.UserManagment
{
    public class IdentityBasicSetup
    {
        public static async Task SetupDefaultUserAndRoles(IServiceProvider serviceProvider)
        {
            var userManager = serviceProvider.GetRequiredService<AppUserManager>();
            var roleManager= serviceProvider.GetRequiredService<RoleManager<AppRole>>();
            var roleStore = serviceProvider.GetRequiredService<AppRoleStore>();

            var username = "admin";
            var pass = "123456";
            var adminRoleName = "admin";
            var eMail = "a@dmin.com";

            if (! await roleManager.RoleExistsAsync(adminRoleName))
            {
                var result = await roleManager.CreateAsync(new AppRole(adminRoleName));
            }

            var user = await userManager.FindByNameAsync(username);
            if (user == null)
            {
                user = new AppUser() {UserName = username, Email = eMail};
                var result = await userManager.CreateAsync(user, pass);
                if (result.Succeeded)
                {
                    var adminRole = await roleStore.FindByNameAsync("admin");
                    var roleResult = await userManager.AddToRoleAsync(user,"admin");
                }
            }

        }
    }
}
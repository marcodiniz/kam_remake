using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Kam.Domain.Models;
using Microsoft.AspNet.Identity;

namespace Kam.Security.UserManagment
{
    public static class CustomValidators
    {
        public static void ConfigureRules(IdentityOptions o)
        {
            o.Password.RequireDigit = false;
            o.Password.RequireLowercase= false;
            o.Password.RequireNonLetterOrDigit = false;
            o.Password.RequireUppercase= false;
            o.Password.RequiredLength = 6;
            o.User.RequireUniqueEmail = true;


        }
    }
}
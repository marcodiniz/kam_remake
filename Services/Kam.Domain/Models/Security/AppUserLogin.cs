using System;
using Kam.Domain.Base;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Kam.Domain.Models
{
    public class AppUserLogin : IdentityUserLogin<long>
    {
        public AppUserLogin()
        {
           
        }
     
    }
}
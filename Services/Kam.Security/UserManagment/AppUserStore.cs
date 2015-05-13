using Kam.Domain.Models;
using Kam.ORM;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Kam.Security.UserManagment
{
    public class AppUserStore<T> : UserStore<AppUser,AppRole,KamContext,long>
    {
        public AppUserStore() : this(new KamContext())
        {
        }

        public AppUserStore(KamContext context, IdentityErrorDescriber describer = null) : base(context, describer)
        {
        }
    }
}
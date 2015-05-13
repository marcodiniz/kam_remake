using Kam.Domain.Models;
using Kam.ORM;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Kam.Security.UserManagment
{
    public class AppRoleStore : RoleStore<AppRole,KamContext,long>
    {
        public AppRoleStore():this(new KamContext())
        {
            
        }

        public AppRoleStore(KamContext context, IdentityErrorDescriber describer = null) : base(context, describer)
        {
        }
    }
}
using Kam.Domain.Models;
using Kam.ORM;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Kam.Security.UserManagment
{
    public class AppRoleStore : RoleStore<AppRole,KamContext,long>
    {
        public AppRoleStore(KamContext context, IdentityErrorDescriber describer = null) : base(context, describer)
        {
        }

        public override long ConvertIdFromString(string id)
        {
            return base.ConvertIdFromString(id);
        }
    }
}
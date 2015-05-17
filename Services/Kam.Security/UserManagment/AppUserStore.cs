using Kam.Domain.Models;
using Kam.ORM;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Kam.Security.UserManagment
{
    public class AppUserStore : UserStore<AppUser,AppRole,KamContext,long>
    {
        public override long ConvertIdFromString(string id)
        {
            var intId = 0;
            int.TryParse(id, out intId);
            return intId;
        }

        public AppUserStore() : this(new KamContext())
        {
        }

        public AppUserStore(KamContext context, IdentityErrorDescriber describer = null) : base(context, describer)
        {
        }
    }
}
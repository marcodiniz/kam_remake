using System.Security.Claims;
using System.Threading.Tasks;
using Kam.Domain.Models;
using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Identity;
using Microsoft.Framework.Logging;
using Microsoft.Framework.OptionsModel;

namespace Kam.Security.UserManagment
{
    public class AppSigninManager : SignInManager<AppUser>
    {
        public AppSigninManager(AppUserManager userManager, IHttpContextAccessor contextAccessor, IUserClaimsPrincipalFactory<AppUser> claimsFactory, 
            IOptions<IdentityOptions> optionsAccessor = null, ILogger<SignInManager<AppUser>> logger = null) : base(userManager, contextAccessor, claimsFactory, optionsAccessor, logger)
        {
        }

        public override Task<AppUser> ValidateSecurityStampAsync(ClaimsPrincipal principal, string userId)
        {
            return base.ValidateSecurityStampAsync(principal, userId);
        }
    }
}
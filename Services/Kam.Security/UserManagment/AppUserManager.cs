using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Kam.Domain.Models;
using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Identity;
using Microsoft.Framework.Logging;
using Microsoft.Framework.OptionsModel;

namespace Kam.Security.UserManagment
{
    public class AppUserManager : UserManager<AppUser>
    {
        private AppUserManager(IUserStore<AppUser> store, IOptions<IdentityOptions> optionsAccessor, IPasswordHasher<AppUser> passwordHasher, 
            IEnumerable<IUserValidator<AppUser>> userValidators, IEnumerable<IPasswordValidator<AppUser>> passwordValidators, ILookupNormalizer keyNormalizer,
            IdentityErrorDescriber errors, IEnumerable<IUserTokenProvider<AppUser>> tokenProviders, ILoggerFactory logger, IHttpContextAccessor contextAccessor) 
            : base(store, optionsAccessor, passwordHasher, userValidators, passwordValidators, keyNormalizer, errors, tokenProviders, logger, contextAccessor)
        {
        }

    }


}
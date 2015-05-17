using System;
using System.Collections.Generic;
using System.Linq;
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
        public AppUserManager(AppUserStore store, IOptions<IdentityOptions> optionsAccessor, IPasswordHasher<AppUser> passwordHasher, 
            IEnumerable<IUserValidator<AppUser>> userValidators, IEnumerable<IPasswordValidator<AppUser>> passwordValidators, ILookupNormalizer keyNormalizer,
            IdentityErrorDescriber errors, IEnumerable<IUserTokenProvider<AppUser>> tokenProviders, ILogger<UserManager<AppUser>> logger, IHttpContextAccessor contextAccessor) 
            : base(store, optionsAccessor, passwordHasher, userValidators, passwordValidators, keyNormalizer, errors, tokenProviders, logger, contextAccessor)
        {
        }
    }

    //public class AppUserManagerFactory
    //{
    //    private readonly IUserStore<AppUser> _store;
    //    private readonly IOptions<IdentityOptions> _optionsAccessor;
    //    private readonly IPasswordHasher<AppUser> _passwordHasher;
    //    private readonly IEnumerable<IUserValidator<AppUser>> _userValidators;
    //    private readonly IEnumerable<IPasswordValidator<AppUser>> _passwordValidators;
    //    private readonly ILookupNormalizer _keyNormalizer;
    //    private readonly IdentityErrorDescriber _errors;
    //    private readonly IEnumerable<IUserTokenProvider<AppUser>> _tokenProviders;
    //    private readonly ILoggerFactory _logger;
    //    private readonly IHttpContextAccessor _contextAccessor;

    //    public AppUserManagerFactory(IUserStore<AppUser> store, IOptions<IdentityOptions> optionsAccessor, IPasswordHasher<AppUser> passwordHasher,
    //        IEnumerable<IUserValidator<AppUser>> userValidators, IEnumerable<IPasswordValidator<AppUser>> passwordValidators, ILookupNormalizer keyNormalizer,
    //        IdentityErrorDescriber errors, IEnumerable<IUserTokenProvider<AppUser>> tokenProviders, ILoggerFactory logger, IHttpContextAccessor contextAccessor)
    //    {
    //        _store = store;
    //        _optionsAccessor = optionsAccessor;
    //        _passwordHasher = passwordHasher;
    //        _userValidators = userValidators;
    //        _passwordValidators = passwordValidators;
    //        _keyNormalizer = keyNormalizer;
    //        _errors = errors;
    //        _tokenProviders = tokenProviders;
    //        _logger = logger;
    //        _contextAccessor = contextAccessor;
    //    }

    //    public AppUserManager Build()
    //    {
    //        _passwordValidators.ToList().Add(new PasswordValidator<AppUser>());

    //        var aum = new AppUserManager(_store, _optionsAccessor, _passwordHasher, _userValidators, _passwordValidators,
    //            _keyNormalizer, _errors, _tokenProviders, _logger, _contextAccessor);

            
    //        return aum;
    //    }
    //}

}
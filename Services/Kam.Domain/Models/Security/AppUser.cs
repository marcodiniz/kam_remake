using System;
using Kam.Domain.Base;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Kam.Domain.Models
{
    public class AppUser : IdentityUser<long>, IEntityBase
    {
        #region Base Properties
        //
        // Summary:
        //     Used to record failures for the purposes of lockout
        //public virtual int AccessFailedCount { get; set; }
        //
        // Summary:
        //     Navigation property for users claims
        //public virtual ICollection<IdentityUserClaim<TKey>> Claims { get; }
        //
        // Summary:
        //     A random value that should change whenever a user is persisted to the store
        //public virtual string ConcurrencyStamp { get; set; }
        //
        // Summary:
        //     Email
        // public virtual string Email { get; set; }
        //
        // Summary:
        //     True if the email is confirmed, default is false
        // public virtual bool EmailConfirmed { get; set; }
        //public virtual TKey Id { get; set; }
        //
        // Summary:
        //     Is lockout enabled for this user
        //public virtual bool LockoutEnabled { get; set; }
        //
        // Summary:
        //     DateTime in UTC when lockout ends, any time in the past is considered not locked
        //     out.
        // public virtual DateTimeOffset? LockoutEnd { get; set; }
        //
        // Summary:
        //     Navigation property for users logins
        //public virtual ICollection<IdentityUserLogin<TKey>> Logins { get; }
        //public virtual string NormalizedEmail { get; set; }
        //public virtual string NormalizedUserName { get; set; }
        //
        // Summary:
        //     The salted/hashed form of the user password
        //public virtual string PasswordHash { get; set; }
        //
        // Summary:
        //     PhoneNumber for the user
        //public virtual string PhoneNumber { get; set; }
        //
        // Summary:
        //     True if the phone number is confirmed, default is false
        //public virtual bool PhoneNumberConfirmed { get; set; }
        //
        // Summary:
        //     Navigation property for users in the role
        //public virtual ICollection<IdentityUserRole<TKey>> Roles { get; }
        //
        // Summary:
        //     A random value that should change whenever a users credentials change (password
        //     changed, login removed)
        // public virtual string SecurityStamp { get; set; }
        //
        // Summary:
        //     Is two factor enabled for the user
        // public virtual bool TwoFactorEnabled { get; set; }
        //public virtual string UserName { get; set; }
        #endregion

        public int Age { get; set; }
        public Type GetEntityType()
        {
            return typeof (AppUser);
        }
    }
}
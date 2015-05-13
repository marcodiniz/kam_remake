using System;
using System.Collections.Generic;
using Kam.Domain.Base;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Kam.Domain.Models
{
    public class AppRole : IdentityRole<long>, IEntityBase
    {
        public override ICollection<IdentityUserRole<long>> Users { get; }

        public AppRole()
        {
            
        }

        public AppRole(string name)
        {
            this.Name = name;
        }

        public string Description { get; set; }

        public Type GetEntityType()
        {
            return typeof (AppRole);
        }
    }
}
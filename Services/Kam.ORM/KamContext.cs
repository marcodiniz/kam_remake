using System.Linq;
using Kam.Domain.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Query;

namespace Kam.ORM
{
    public class KamContext : DbContext
    {
        public DbSet<AppRoleClaim> RoleClaims { get; set; }
        public DbSet<AppRole> Roles { get; set; }
        public DbSet<AppUserClaim> UserClaims { get; set; }
        public DbSet<AppUserLogin> UserLogins { get; set; }
        public DbSet<AppUserRole> UserRoles { get; set; }
        public DbSet<AppUser> Users { get; set; }

        private static bool _isCreated = false;

        public KamContext()
        {
            if (!_isCreated)
            {
                Database.AsSqlServer().ApplyMigrations();
                _isCreated = true;
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                                        "Server=.\\SQLEXPRESS;Database=KamDev;Trusted_Connection=True;MultipleActiveResultSets=true");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder b)
        {
            foreach (var e in b.Model.EntityTypes)
            {
                var concProperty = e.FindProperty("ConcurrencyStamp");
                if (concProperty != null)
                    concProperty.IsConcurrencyToken = true;
            }

            b.Entity<AppUserLogin>()
                .Key(x => x.UserId);

            b.Entity<AppUserRole>()
                .Key(x => new {x.RoleId, x.UserId});

        }
    }
}
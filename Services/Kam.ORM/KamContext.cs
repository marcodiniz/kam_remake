using System.Linq;
using Kam.Domain.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Query;

namespace Kam.ORM
{
    public class KamContext : IdentityDbContext<AppUser, AppRole, long>
    {
        public KamContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=KamDev;Trusted_Connection=True;MultipleActiveResultSets=true");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder b)
        {
            base.OnModelCreating(b);

            var allProperties = b.Model.EntityTypes.SelectMany(x => x.Properties);

            allProperties.Where(x => x.Name == "Id")
                .ToList()
                .ForEach(x => x.IsPrimaryKey());

            foreach (var e in b.Model.EntityTypes)
            {
                var concProperty = e.FindProperty("ConcurrencyStamp");
                if (concProperty != null)
                    concProperty.IsConcurrencyToken = true;
            }

        }
    }
}
using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Relational.Migrations.Infrastructure;
using Kam.ORM;

namespace Kam.ORM.Migrations
{
    [ContextType(typeof(KamContext))]
    partial class Initial
    {
        public override string Id
        {
            get { return "20150517034134_Initial"; }
        }
        
        public override string ProductVersion
        {
            get { return "7.0.0-beta5-13202"; }
        }
        
        public override void BuildTargetModel(ModelBuilder builder)
        {
            builder
                .Annotation("SqlServer:ValueGeneration", "Identity");
            
            builder.Entity("Kam.Domain.Models.AppRole", b =>
                {
                    b.Property<long>("Id")
                        .GenerateValueOnAdd()
                        .StoreGeneratedPattern(StoreGeneratedPattern.Identity)
                        .Annotation("OriginalValueIndex", 0);
                    
                    b.Property<string>("ConcurrencyStamp")
                        .ConcurrencyToken()
                        .Annotation("OriginalValueIndex", 1);
                    
                    b.Property<string>("Description")
                        .Annotation("OriginalValueIndex", 2);
                    
                    b.Property<string>("Name")
                        .Annotation("OriginalValueIndex", 3);
                    
                    b.Property<string>("NormalizedName")
                        .Annotation("OriginalValueIndex", 4);
                    
                    b.Key("Id");
                    
                    b.Annotation("Relational:TableName", "AspNetRoles");
                });
            
            builder.Entity("Kam.Domain.Models.AppUser", b =>
                {
                    b.Property<long>("Id")
                        .GenerateValueOnAdd()
                        .StoreGeneratedPattern(StoreGeneratedPattern.Identity)
                        .Annotation("OriginalValueIndex", 0);
                    
                    b.Property<int>("AccessFailedCount")
                        .Annotation("OriginalValueIndex", 1);
                    
                    b.Property<int>("Age")
                        .Annotation("OriginalValueIndex", 2);
                    
                    b.Property<string>("ConcurrencyStamp")
                        .ConcurrencyToken()
                        .Annotation("OriginalValueIndex", 3);
                    
                    b.Property<string>("Email")
                        .Annotation("OriginalValueIndex", 4);
                    
                    b.Property<bool>("EmailConfirmed")
                        .Annotation("OriginalValueIndex", 5);
                    
                    b.Property<bool>("LockoutEnabled")
                        .Annotation("OriginalValueIndex", 6);
                    
                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .Annotation("OriginalValueIndex", 7);
                    
                    b.Property<string>("NormalizedEmail")
                        .Annotation("OriginalValueIndex", 8);
                    
                    b.Property<string>("NormalizedUserName")
                        .Annotation("OriginalValueIndex", 9);
                    
                    b.Property<string>("PasswordHash")
                        .Annotation("OriginalValueIndex", 10);
                    
                    b.Property<string>("PhoneNumber")
                        .Annotation("OriginalValueIndex", 11);
                    
                    b.Property<bool>("PhoneNumberConfirmed")
                        .Annotation("OriginalValueIndex", 12);
                    
                    b.Property<string>("SecurityStamp")
                        .Annotation("OriginalValueIndex", 13);
                    
                    b.Property<bool>("TwoFactorEnabled")
                        .Annotation("OriginalValueIndex", 14);
                    
                    b.Property<string>("UserName")
                        .Annotation("OriginalValueIndex", 15);
                    
                    b.Key("Id");
                    
                    b.Annotation("Relational:TableName", "AspNetUsers");
                });
            
            builder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityRoleClaim<long>", b =>
                {
                    b.Property<int>("Id")
                        .GenerateValueOnAdd()
                        .StoreGeneratedPattern(StoreGeneratedPattern.Identity)
                        .Annotation("OriginalValueIndex", 0);
                    
                    b.Property<string>("ClaimType")
                        .Annotation("OriginalValueIndex", 1);
                    
                    b.Property<string>("ClaimValue")
                        .Annotation("OriginalValueIndex", 2);
                    
                    b.Property<long>("RoleId")
                        .Annotation("OriginalValueIndex", 3);
                    
                    b.Key("Id");
                    
                    b.Annotation("Relational:TableName", "AspNetRoleClaims");
                });
            
            builder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserClaim<long>", b =>
                {
                    b.Property<int>("Id")
                        .GenerateValueOnAdd()
                        .StoreGeneratedPattern(StoreGeneratedPattern.Identity)
                        .Annotation("OriginalValueIndex", 0);
                    
                    b.Property<string>("ClaimType")
                        .Annotation("OriginalValueIndex", 1);
                    
                    b.Property<string>("ClaimValue")
                        .Annotation("OriginalValueIndex", 2);
                    
                    b.Property<long>("UserId")
                        .Annotation("OriginalValueIndex", 3);
                    
                    b.Key("Id");
                    
                    b.Annotation("Relational:TableName", "AspNetUserClaims");
                });
            
            builder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserLogin<long>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .GenerateValueOnAdd()
                        .Annotation("OriginalValueIndex", 0);
                    
                    b.Property<string>("ProviderKey")
                        .GenerateValueOnAdd()
                        .Annotation("OriginalValueIndex", 1);
                    
                    b.Property<string>("ProviderDisplayName")
                        .Annotation("OriginalValueIndex", 2);
                    
                    b.Property<long>("UserId")
                        .Annotation("OriginalValueIndex", 3);
                    
                    b.Key("LoginProvider", "ProviderKey");
                    
                    b.Annotation("Relational:TableName", "AspNetUserLogins");
                });
            
            builder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserRole<long>", b =>
                {
                    b.Property<long>("UserId")
                        .Annotation("OriginalValueIndex", 0);
                    
                    b.Property<long>("RoleId")
                        .Annotation("OriginalValueIndex", 1);
                    
                    b.Key("UserId", "RoleId");
                    
                    b.Annotation("Relational:TableName", "AspNetUserRoles");
                });
            
            builder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityRoleClaim<long>", b =>
                {
                    b.Reference("Kam.Domain.Models.AppRole")
                        .InverseCollection()
                        .ForeignKey("RoleId");
                });
            
            builder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserClaim<long>", b =>
                {
                    b.Reference("Kam.Domain.Models.AppUser")
                        .InverseCollection()
                        .ForeignKey("UserId");
                });
            
            builder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserLogin<long>", b =>
                {
                    b.Reference("Kam.Domain.Models.AppUser")
                        .InverseCollection()
                        .ForeignKey("UserId");
                });
            
            builder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserRole<long>", b =>
                {
                    b.Reference("Kam.Domain.Models.AppRole")
                        .InverseCollection()
                        .ForeignKey("RoleId");
                    
                    b.Reference("Kam.Domain.Models.AppUser")
                        .InverseCollection()
                        .ForeignKey("UserId");
                });
        }
    }
}

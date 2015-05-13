using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Metadata.Builders;
using Microsoft.Data.Entity.Relational.Migrations.Infrastructure;
using Kam.ORM;

namespace Kam.ORM.Migrations
{
    [ContextType(typeof(KamContext))]
    partial class Initial
    {
        public override string Id
        {
            get { return "20150512233354_Initial"; }
        }
        
        public override string ProductVersion
        {
            get { return "7.0.0-beta4-12943"; }
        }
        
        public override IModel Target
        {
            get
            {
                var builder = new BasicModelBuilder()
                    .Annotation("SqlServer:ValueGeneration", "Sequence");
                
                builder.Entity("Kam.Domain.Models.AppRole", b =>
                    {
                        b.Property<string>("ConcurrencyStamp")
                            .Annotation("OriginalValueIndex", 0);
                        b.Property<string>("Description")
                            .Annotation("OriginalValueIndex", 1);
                        b.Property<long>("Id")
                            .GenerateValueOnAdd()
                            .Annotation("OriginalValueIndex", 2)
                            .Annotation("SqlServer:ValueGeneration", "Default");
                        b.Property<string>("Name")
                            .Annotation("OriginalValueIndex", 3);
                        b.Property<string>("NormalizedName")
                            .Annotation("OriginalValueIndex", 4);
                        b.Key("Id");
                    });
                
                builder.Entity("Kam.Domain.Models.AppRoleClaim", b =>
                    {
                        b.Property<string>("ClaimType")
                            .Annotation("OriginalValueIndex", 0);
                        b.Property<string>("ClaimValue")
                            .Annotation("OriginalValueIndex", 1);
                        b.Property<int>("Id")
                            .GenerateValueOnAdd()
                            .Annotation("OriginalValueIndex", 2)
                            .Annotation("SqlServer:ValueGeneration", "Default");
                        b.Property<long>("RoleId")
                            .Annotation("OriginalValueIndex", 3);
                        b.Key("Id");
                    });
                
                builder.Entity("Kam.Domain.Models.AppUser", b =>
                    {
                        b.Property<int>("AccessFailedCount")
                            .Annotation("OriginalValueIndex", 0);
                        b.Property<int>("Age")
                            .Annotation("OriginalValueIndex", 1);
                        b.Property<string>("ConcurrencyStamp")
                            .Annotation("OriginalValueIndex", 2);
                        b.Property<string>("Email")
                            .Annotation("OriginalValueIndex", 3);
                        b.Property<bool>("EmailConfirmed")
                            .Annotation("OriginalValueIndex", 4);
                        b.Property<long>("Id")
                            .GenerateValueOnAdd()
                            .Annotation("OriginalValueIndex", 5)
                            .Annotation("SqlServer:ValueGeneration", "Default");
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
                    });
                
                builder.Entity("Kam.Domain.Models.AppUserClaim", b =>
                    {
                        b.Property<string>("ClaimType")
                            .Annotation("OriginalValueIndex", 0);
                        b.Property<string>("ClaimValue")
                            .Annotation("OriginalValueIndex", 1);
                        b.Property<int>("Id")
                            .GenerateValueOnAdd()
                            .Annotation("OriginalValueIndex", 2)
                            .Annotation("SqlServer:ValueGeneration", "Default");
                        b.Property<long>("UserId")
                            .Annotation("OriginalValueIndex", 3);
                        b.Key("Id");
                    });
                
                builder.Entity("Kam.Domain.Models.AppUserLogin", b =>
                    {
                        b.Property<string>("LoginProvider")
                            .Annotation("OriginalValueIndex", 0);
                        b.Property<string>("ProviderDisplayName")
                            .Annotation("OriginalValueIndex", 1);
                        b.Property<string>("ProviderKey")
                            .Annotation("OriginalValueIndex", 2);
                        b.Property<long>("UserId")
                            .GenerateValueOnAdd()
                            .Annotation("OriginalValueIndex", 3)
                            .Annotation("SqlServer:ValueGeneration", "Default");
                        b.Key("UserId");
                    });
                
                builder.Entity("Kam.Domain.Models.AppUserRole", b =>
                    {
                        b.Property<long>("RoleId")
                            .GenerateValueOnAdd()
                            .Annotation("OriginalValueIndex", 0);
                        b.Property<long>("UserId")
                            .GenerateValueOnAdd()
                            .Annotation("OriginalValueIndex", 1);
                        b.Key("RoleId", "UserId");
                    });
                
                return builder.Model;
            }
        }
    }
}

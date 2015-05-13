using System.Collections.Generic;
using Microsoft.Data.Entity.Relational.Migrations;
using Microsoft.Data.Entity.Relational.Migrations.Builders;
using Microsoft.Data.Entity.Relational.Migrations.Operations;

namespace Kam.ORM.Migrations
{
    public partial class Initial : Migration
    {
        public override void Up(MigrationBuilder migration)
        {
            migration.CreateSequence(
                name: "DefaultSequence",
                type: "bigint",
                startWith: 1L,
                incrementBy: 10);
            migration.CreateTable(
                name: "AppRole",
                columns: table => new
                {
                    ConcurrencyStamp = table.Column(type: "nvarchar(max)", nullable: true),
                    Description = table.Column(type: "nvarchar(max)", nullable: true),
                    Id = table.Column(type: "bigint", nullable: false),
                    Name = table.Column(type: "nvarchar(max)", nullable: true),
                    NormalizedName = table.Column(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRole", x => x.Id);
                });
            migration.CreateTable(
                name: "AppRoleClaim",
                columns: table => new
                {
                    ClaimType = table.Column(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column(type: "nvarchar(max)", nullable: true),
                    Id = table.Column(type: "int", nullable: false),
                    RoleId = table.Column(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRoleClaim", x => x.Id);
                });
            migration.CreateTable(
                name: "AppUser",
                columns: table => new
                {
                    AccessFailedCount = table.Column(type: "int", nullable: false),
                    Age = table.Column(type: "int", nullable: false),
                    ConcurrencyStamp = table.Column(type: "nvarchar(max)", nullable: true),
                    Email = table.Column(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column(type: "bit", nullable: false),
                    Id = table.Column(type: "bigint", nullable: false),
                    LockoutEnabled = table.Column(type: "bit", nullable: false),
                    LockoutEnd = table.Column(type: "datetimeoffset", nullable: true),
                    NormalizedEmail = table.Column(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column(type: "bit", nullable: false),
                    SecurityStamp = table.Column(type: "nvarchar(max)", nullable: true),
                    TwoFactorEnabled = table.Column(type: "bit", nullable: false),
                    UserName = table.Column(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUser", x => x.Id);
                });
            migration.CreateTable(
                name: "AppUserClaim",
                columns: table => new
                {
                    ClaimType = table.Column(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column(type: "nvarchar(max)", nullable: true),
                    Id = table.Column(type: "int", nullable: false),
                    UserId = table.Column(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserClaim", x => x.Id);
                });
            migration.CreateTable(
                name: "AppUserLogin",
                columns: table => new
                {
                    LoginProvider = table.Column(type: "nvarchar(max)", nullable: true),
                    ProviderDisplayName = table.Column(type: "nvarchar(max)", nullable: true),
                    ProviderKey = table.Column(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserLogin", x => x.UserId);
                });
            migration.CreateTable(
                name: "AppUserRole",
                columns: table => new
                {
                    RoleId = table.Column(type: "bigint", nullable: false),
                    UserId = table.Column(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserRole", x => new { x.RoleId, x.UserId });
                });
        }
        
        public override void Down(MigrationBuilder migration)
        {
            migration.DropSequence("DefaultSequence");
            migration.DropTable("AppRole");
            migration.DropTable("AppRoleClaim");
            migration.DropTable("AppUser");
            migration.DropTable("AppUserClaim");
            migration.DropTable("AppUserLogin");
            migration.DropTable("AppUserRole");
        }
    }
}

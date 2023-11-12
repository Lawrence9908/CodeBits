using CodeBits.API.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CodeBits.API.Utility;

namespace CodeBits.API.Data
{
    public class ApplicationDbContext: IdentityDbContext<AppUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }

        public DbSet<AppUser> Users {  get; set; }
        public DbSet<Category>  Categories { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Reply> Replys { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = "84935ABF-D8D6-4704-8AA7-78FCD827BE8D",
                    Name = Role.Role_Admin,
                    NormalizedName = Role.Role_Admin.ToUpper(),
                },
                new IdentityRole
                {
                    Id = "BC0BDDCB-5934-4737-ADD3-FD0CC3799CAB",
                    Name = Role.Role_User,
                    NormalizedName = Role.Role_User.ToUpper(),
                },
                new IdentityRole
                {
                    Id = "FF0A935F-E2AE-4BF7-94DC-A877E4C835C2",
                    Name = Role.Role_Writer,
                    NormalizedName= Role.Role_Writer.ToUpper(),

                }
            
           );
        }
    }
}

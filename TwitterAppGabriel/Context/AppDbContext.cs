using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using System.Net.Mail;
using TwitterAppGabriel.Entities;
using static System.Net.Mime.MediaTypeNames;

namespace TwitterAppGabriel.Context
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :
            base(options)
        { }
        public DbSet<User> Users { get; set; }

        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); //adding a data once the app is run
            modelBuilder.Entity<User>().HasData
            (new User
            {
                UserId = 1,
                Name = "Gabriel",
                EmailAddress = "gabriel_hachmann@dell.com",
                Bio = "I work for Dell",
                Tweet = "I'm working today",
                Comment = "Nice",
            });
        }*/
    }
}

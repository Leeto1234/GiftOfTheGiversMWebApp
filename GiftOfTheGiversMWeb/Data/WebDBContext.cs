using GiftOfTheGiversMWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace GiftOfTheGiversMWeb.Data
{
    public class WebDBContext:DbContext
    {
        public WebDBContext(DbContextOptions<WebDBContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Alert> Alerts { get; set; }
        public DbSet<Donation> Donations { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Volunteer> Volunteers { get; set; }

        
    }
}

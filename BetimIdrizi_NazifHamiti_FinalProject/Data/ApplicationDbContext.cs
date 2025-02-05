using BetimIdrizi_NazifHamiti_FinalProject.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace BetimIdrizi_NazifHamiti_FinalProject.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole, string>
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Review> Reviews { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}

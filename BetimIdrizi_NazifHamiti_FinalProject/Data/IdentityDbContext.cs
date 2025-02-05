using Microsoft.EntityFrameworkCore;

namespace BetimIdrizi_NazifHamiti_FinalProject.Data
{
    public class IdentityDbContext<T>
    {
        private DbContextOptions<ApplicationDbContext> options;

        public IdentityDbContext(DbContextOptions<ApplicationDbContext> options)
        {
            this.options = options;
        }
    }
}

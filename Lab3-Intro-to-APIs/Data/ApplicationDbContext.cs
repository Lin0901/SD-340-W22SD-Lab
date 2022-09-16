using Microsoft.EntityFrameworkCore;

namespace Lab3_Intro_to_APIs.Data
{
        public class ApplicationDbContext : DbContext
        {
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                : base(options)
            {
            }
            public DbSet<Lab3_Intro_to_APIs.Models.Route>? Routes { get; set; }
            public DbSet<Lab3_Intro_to_APIs.Models.ScheduledStop>? ScheduledStops { get; set; }
            public DbSet<Lab3_Intro_to_APIs.Models.Stop>? Stops { get; set; }

        }  
}

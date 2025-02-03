using Microsoft.EntityFrameworkCore;
using RecordManagemant.Data.Seeds;
using RecordManagemant.Entities;
using RecordManagemant.Entities;
using System.Reflection;

namespace RecordManagemant.Data
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Record> Records { get; set; }
        public DbSet<Nationality> Nationalities { get ; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
                .UseSeeding((context, _) =>
                {
                    var nationalities = NationalitiesSeed.SeedData();

                    foreach (var nationality in nationalities)
                    {
                        if (!context.Set<Nationality>().Any(p => p.Id == nationality.Id))
                        {
                            context.Set<Nationality>().Add(nationality);
                        }
                    }

                    context.SaveChanges();
                })
                .UseAsyncSeeding(async (context, _, cancellationToken) =>
                {
                    var nationalities = NationalitiesSeed.SeedData();

                    foreach (var nationality in nationalities)
                    {
                        if (!await context.Set<Nationality>().AnyAsync(p => p.Name == nationality.Name))
                        {
                            await context.Set<Nationality>().AddAsync(nationality);
                        }
                    }

                    await context.SaveChangesAsync();
                });
    }
}

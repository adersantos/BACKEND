using System;

namespace teste_squadra_api.context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
            { }

        public DbSet<evento>? Evento {get; set; }
        public DbSet<contact>? Contact {get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Evento>().HasData(
            {
                Id = 1,
                DateCreated = DateTime.Now,
                Price = 10m,
                FirstName = 'Ader',
                Suburb = 'Suburb',
                Category = 'Categoria',
                Description = 'Plaster exposed brick walls (see photos).'
            });
        }
    }
}

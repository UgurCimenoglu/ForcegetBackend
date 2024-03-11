using Forceget.Core.Entities;
using Forceget.DataAccess.Extensions;
using Forceget.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Forceget.DataAccess.Context
{
    public class ForcegetDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(Configuration.ConnectionString);
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Mode> Modes { get; set; }
        public DbSet<MovementType> MovementTypes { get; set; }
        public DbSet<Incoterm> Incoterms { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<PackageType> PackageTypes { get; set; }
        public DbSet<Unit1> Unit1s { get; set; }
        public DbSet<Unit2> Unit2s { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Offer> Offers { get; set; }


        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            //ChangeTracker Entityler üzerinde yapılan değişikliklerin veya yeni eklenen verinin yakalanmasını sağlayan propertydir.
            //Update operasyonlarında track edilen verileri yakalayıp elde etmemeizi sağlar.
            var datas = ChangeTracker.Entries<BaseEntity>();
            foreach (var data in datas)
            {
                _ = data.State switch
                {
                    EntityState.Added => data.Entity.CreatedDate = DateTime.UtcNow,
                    EntityState.Modified => data.Entity.UpdatedDate = DateTime.UtcNow,
                    _ => DateTime.UtcNow
                };
            }

            return base.SaveChangesAsync(cancellationToken);
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    //Seed Data initializing
        //    modelBuilder.InitializeSeedData();
        //    base.OnModelCreating(modelBuilder);
        //}
    }
}

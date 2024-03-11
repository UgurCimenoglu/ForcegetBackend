using Forceget.Core.Entities;
using Forceget.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forceget.DataAccess.Context
{
    public static class EnsureSeedData
    {
        public static void InitializeSeedData(this ModelBuilder modelBuilder)
        {

            //Veritabanında herhangi bir veri var mı kontrol ediyoruz
            if (!modelBuilder.Model.GetEntityTypes().Any(t => t.Name == "Mode"))
            {
                modelBuilder.Entity<Mode>().HasData(
                                   new Mode { Id = Guid.NewGuid(), Name = "LCL", CreatedDate = DateTime.Now, UpdatedDate = null },
                                   new Mode { Id = Guid.NewGuid(), Name = "FCL", CreatedDate = DateTime.Now, UpdatedDate = null },
                                   new Mode { Id = Guid.NewGuid(), Name = "Air", CreatedDate = DateTime.Now, UpdatedDate = null }
                               );
            }

            if (!modelBuilder.Model.GetEntityTypes().Any(t => t.ClrType == typeof(MovementType)))
            {
                modelBuilder.Entity<MovementType>().HasData(
                        new MovementType { Id = Guid.NewGuid(), Name = "Door to Door", CreatedDate = DateTime.Now, UpdatedDate = null },
                        new MovementType { Id = Guid.NewGuid(), Name = "Port to Door", CreatedDate = DateTime.Now, UpdatedDate = null },
                        new MovementType { Id = Guid.NewGuid(), Name = "Door to Port", CreatedDate = DateTime.Now, UpdatedDate = null },
                        new MovementType { Id = Guid.NewGuid(), Name = "Port to Port", CreatedDate = DateTime.Now, UpdatedDate = null }
                    );
            }

            if (!modelBuilder.Model.GetEntityTypes().Any(t => t.ClrType == typeof(Incoterm)))
            {
                modelBuilder.Entity<Incoterm>().HasData(
                        new Incoterm { Id = Guid.NewGuid(), Name = "Delivered Duty Paid (DDP)", CreatedDate = DateTime.Now, UpdatedDate = null },
                        new Incoterm { Id = Guid.NewGuid(), Name = "Delivered At Place (DAT)", CreatedDate = DateTime.Now, UpdatedDate = null }
                    );
            }

            if (!modelBuilder.Model.GetEntityTypes().Any(t => t.ClrType == typeof(Country)))
            {
                modelBuilder.Entity<Country>().HasData(
                        new Country
                        {
                            Id = Guid.NewGuid(),
                            Name = "USA",
                            CreatedDate = DateTime.Now,
                            UpdatedDate = null,
                            Cities = new List<City>
                                {
                                new City{Id= Guid.NewGuid(), Name="New York", CreatedDate = DateTime.Now, UpdatedDate = null },
                                new City{Id= Guid.NewGuid(), Name="Los Angeles", CreatedDate = DateTime.Now, UpdatedDate = null },
                                new City{Id= Guid.NewGuid(), Name="Miami", CreatedDate = DateTime.Now, UpdatedDate = null },
                                new City{Id= Guid.NewGuid(), Name="Minnesota", CreatedDate = DateTime.Now, UpdatedDate = null },
                                }
                        },
                        new Country
                        {
                            Id = Guid.NewGuid(),
                            Name = "China",
                            CreatedDate = DateTime.Now,
                            UpdatedDate = null,
                            Cities = new List<City>
                            {
                                new City{Id= Guid.NewGuid(), Name="Beijing", CreatedDate = DateTime.Now, UpdatedDate = null },
                                new City{Id= Guid.NewGuid(), Name="Shanghai", CreatedDate = DateTime.Now, UpdatedDate = null }
                            }
                        },
                        new Country
                        {
                            Id = Guid.NewGuid(),
                            Name = "Turkey",
                            CreatedDate = DateTime.Now,
                            UpdatedDate = null,
                            Cities = new List<City>
                            {
                                new City{Id= Guid.NewGuid(), Name="Istanbul", CreatedDate = DateTime.Now, UpdatedDate = null },
                                new City{Id= Guid.NewGuid(), Name="Izmir", CreatedDate = DateTime.Now, UpdatedDate = null }
                            }
                        }
                    );
            }

            if (!modelBuilder.Model.GetEntityTypes().Any(t => t.ClrType == typeof(PackageType)))
            {
                modelBuilder.Entity<PackageType>().HasData(
                        new PackageType { Id = Guid.NewGuid(), Name = "Pallets", CreatedDate = DateTime.Now, UpdatedDate = null },
                        new PackageType { Id = Guid.NewGuid(), Name = "Boxes", CreatedDate = DateTime.Now, UpdatedDate = null },
                        new PackageType { Id = Guid.NewGuid(), Name = "Cartons", CreatedDate = DateTime.Now, UpdatedDate = null }
                    );
            }

            if (!modelBuilder.Model.GetEntityTypes().Any(t => t.ClrType == typeof(Unit1)))
            {
                modelBuilder.Entity<Unit1>().HasData(
                        new Unit1 { Id = Guid.NewGuid(), Name = "CM", CreatedDate = DateTime.Now, UpdatedDate = null },
                        new Unit1 { Id = Guid.NewGuid(), Name = "IN", CreatedDate = DateTime.Now, UpdatedDate = null }
                    );
            }

            if (!modelBuilder.Model.GetEntityTypes().Any(t => t.ClrType == typeof(Unit2)))
            {
                modelBuilder.Entity<Unit2>().HasData(
                        new Unit2 { Id = Guid.NewGuid(), Name = "KG", CreatedDate = DateTime.Now, UpdatedDate = null },
                        new Unit2 { Id = Guid.NewGuid(), Name = "LB", CreatedDate = DateTime.Now, UpdatedDate = null }
                    );
            }

            if (!modelBuilder.Model.GetEntityTypes().Any(t => t.ClrType == typeof(Currency)))
            {
                modelBuilder.Entity<Currency>().HasData(
                        new Currency { Id = Guid.NewGuid(), Name = "USD - US Dollar", CreatedDate = DateTime.Now, UpdatedDate = null },
                        new Currency { Id = Guid.NewGuid(), Name = "CNY - Chinese Yuan", CreatedDate = DateTime.Now, UpdatedDate = null },
                        new Currency { Id = Guid.NewGuid(), Name = "TRY - Turkish Lira", CreatedDate = DateTime.Now, UpdatedDate = null }
                    );
            }
        }
    }
}

using Forceget.DataAccess.Context;
using Forceget.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forceget.DataAccess.Concrete
{
    public class SeedDataService
    {
        private readonly ForcegetDbContext _context;

        public SeedDataService(ForcegetDbContext context)
        {
            _context = context;
        }

        public async Task EnsureSeedDataAsync()
        {
            var adsa = _context.Modes.Count();
            if (!_context.Modes.Any())
            {
                await _context.Modes.AddRangeAsync(
                    new Mode { Id = Guid.NewGuid(), Name = "LCL", CreatedDate = DateTime.Now, UpdatedDate = null },
                    new Mode { Id = Guid.NewGuid(), Name = "FCL", CreatedDate = DateTime.Now, UpdatedDate = null },
                    new Mode { Id = Guid.NewGuid(), Name = "Air", CreatedDate = DateTime.Now, UpdatedDate = null }
                );
            }
            if (!_context.MovementTypes.Any())
            {
                await _context.MovementTypes.AddRangeAsync(
                    new MovementType { Id = Guid.NewGuid(), Name = "Door to Door", CreatedDate = DateTime.Now, UpdatedDate = null },
                    new MovementType { Id = Guid.NewGuid(), Name = "Port to Door", CreatedDate = DateTime.Now, UpdatedDate = null },
                    new MovementType { Id = Guid.NewGuid(), Name = "Door to Port", CreatedDate = DateTime.Now, UpdatedDate = null },
                    new MovementType { Id = Guid.NewGuid(), Name = "Port to Port", CreatedDate = DateTime.Now, UpdatedDate = null }
                   );
            }
            if (!_context.Incoterms.Any())
            {
                await _context.Incoterms.AddRangeAsync(
                    new Incoterm { Id = Guid.NewGuid(), Name = "Delivered Duty Paid (DDP)", CreatedDate = DateTime.Now, UpdatedDate = null },
                    new Incoterm { Id = Guid.NewGuid(), Name = "Delivered At Place (DAT)", CreatedDate = DateTime.Now, UpdatedDate = null }
                   );
            }
            if (!_context.Countries.Any())
            {
                await _context.Countries.AddRangeAsync(
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
                        });
            }
            if (!_context.PackageTypes.Any())
            {
                await _context.PackageTypes.AddRangeAsync(
                    new PackageType { Id = Guid.NewGuid(), Name = "Pallets", CreatedDate = DateTime.Now, UpdatedDate = null },
                    new PackageType { Id = Guid.NewGuid(), Name = "Boxes", CreatedDate = DateTime.Now, UpdatedDate = null },
                    new PackageType { Id = Guid.NewGuid(), Name = "Cartons", CreatedDate = DateTime.Now, UpdatedDate = null }
                  );
            }
            if (!_context.Unit1s.Any())
            {
                await _context.Unit1s.AddRangeAsync(
                     new Unit1 { Id = Guid.NewGuid(), Name = "CM", CreatedDate = DateTime.Now, UpdatedDate = null },
                    new Unit1 { Id = Guid.NewGuid(), Name = "IN", CreatedDate = DateTime.Now, UpdatedDate = null }
                  );
            }
            if (!_context.Unit2s.Any())
            {
                await _context.Unit2s.AddRangeAsync(
                    new Unit2 { Id = Guid.NewGuid(), Name = "KG", CreatedDate = DateTime.Now, UpdatedDate = null },
                    new Unit2 { Id = Guid.NewGuid(), Name = "LB", CreatedDate = DateTime.Now, UpdatedDate = null }
                  );
            }
            if (!_context.Currencies.Any())
            {
                await _context.Currencies.AddRangeAsync(
                    new Currency { Id = Guid.NewGuid(), Name = "USD - US Dollar", CreatedDate = DateTime.Now, UpdatedDate = null },
                    new Currency { Id = Guid.NewGuid(), Name = "CNY - Chinese Yuan", CreatedDate = DateTime.Now, UpdatedDate = null },
                    new Currency { Id = Guid.NewGuid(), Name = "TRY - Turkish Lira", CreatedDate = DateTime.Now, UpdatedDate = null }
                   );
            }

            await _context.SaveChangesAsync();
        }
    }
}

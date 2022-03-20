using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Salon.Models
{
  public class SalonContext : DbContext
  {
    public DbSet<Client> Clients { get; set; }
    public DbSet<Stylist> Stylists { get; set; }
    public DbSet<StylistClients> StylistClients { get; set; }

    public SalonContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}
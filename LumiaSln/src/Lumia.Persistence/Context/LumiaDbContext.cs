using System.IO;
using Lumia.Application.Interfaces;
using Lumia.Domain.Clientes;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;
using Lumia.Persistence.Mappings;

namespace Lumia.Persistence.Context
{
    public class LumiaDbContext : DbContext
    {
        public LumiaDbContext(DbContextOptions<LumiaDbContext> options)
            : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClienteMapping());

            base.OnModelCreating(modelBuilder);
        }
    }
}

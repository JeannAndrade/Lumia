using System.IO;
using Lumia.Application.Interfaces;
using Lumia.Domain.Clientes;
using Lumia.Persistence.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;
using Lumia.Persistence.Mappings;

namespace Lumia.Persistence
{
    public class DatabaseService : DbContext
    {
        private readonly string connectionString;

        public DatabaseService(string connectionString)
        {
            if (connectionString == null) throw new ArgumentNullException(nameof(connectionString));
            if (string.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentException("Value should not be empty.", nameof(connectionString));

            this.connectionString = connectionString;
        }

        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.AddConfiguration(new ClienteMapping());

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(this.connectionString);
        }
    }
}

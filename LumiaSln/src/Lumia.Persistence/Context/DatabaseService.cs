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
    public class DatabaseService : IDatabaseService
    {
        private readonly LumiaDbContext context;

        public DatabaseService(LumiaDbContext ctx)
        {
            this.context = ctx ?? throw new ArgumentNullException(nameof(ctx));
        }

        public IQueryable<Cliente> Clientes => context.Clientes;
    }
}

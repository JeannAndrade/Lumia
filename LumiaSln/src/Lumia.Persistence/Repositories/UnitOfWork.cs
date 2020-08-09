using Lumia.Application.Interfaces;
using Lumia.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lumia.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly LumiaDbContext _context;

        public UnitOfWork(LumiaDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            Clientes = new ClienteRepository(_context);
        }

        public IClienteRepository Clientes { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }
    }
}

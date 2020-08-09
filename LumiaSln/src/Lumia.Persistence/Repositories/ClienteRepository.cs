using Lumia.Application.Interfaces;
using Lumia.Domain.Clientes;
using Lumia.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lumia.Persistence.Repositories
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        public ClienteRepository(LumiaDbContext context) : base(context)
        {
        }

        public LumiaDbContext LumiaDbContext
        {
            get { return Context as LumiaDbContext; }
        }

    }
}

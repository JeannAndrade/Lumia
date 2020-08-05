using Lumia.Domain.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lumia.Application.Interfaces
{
    public interface IDatabaseService
    {
        IQueryable<Cliente> Clientes { get; }
    }
}

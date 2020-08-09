using System;
using System.Collections.Generic;
using System.Text;

namespace Lumia.Application.Interfaces
{
    public interface IUnitOfWork
    {
        IClienteRepository Clientes { get; }
        int Complete();
    }
}

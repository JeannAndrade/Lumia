using System;
using System.Collections.Generic;
using System.Text;

namespace Lumia.Application.Clientes.Commands.CreateCliente
{
    public interface ICreateClienteCommand
    {
        void Execute(CreateClienteModel model);
    }
}

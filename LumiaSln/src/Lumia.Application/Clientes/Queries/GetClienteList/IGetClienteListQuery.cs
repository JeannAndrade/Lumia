using System;
using System.Collections.Generic;
using System.Text;

namespace Lumia.Application.Clientes.Queries.GetClienteList
{
    public interface IGetClienteListQuery
    {
        List<ClienteModel> Execute();
    }
}

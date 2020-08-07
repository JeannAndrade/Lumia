using Lumia.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lumia.Application.Clientes.Queries.GetClienteList
{
    public class GetClientesListQuery : IGetClientesListQuery
    {
        private readonly IDatabaseService _database;

        public GetClientesListQuery(IDatabaseService database)
        {
            _database = database ?? throw new ArgumentNullException(nameof(database));
        }

        public IEnumerable<ClienteModel> Execute()
        {
            var customers = _database.Clientes
               .Select(p => new ClienteModel()
               {
                   Id = p.Id,
                   Nome = p.Nome,
                   Email = p.Email,
                   Endereco = p.Endereco,
                   Telefone = p.Telefone,
                   Observacao = p.Observacao
               });

            return customers.ToList();
        }
    }
}

using AutoMapper;
using Lumia.Application.Interfaces;
using Lumia.Domain.Clientes;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lumia.Application.Clientes.Queries.GetClienteList
{
    public class GetClientesListQuery : IGetClientesListQuery
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public GetClientesListQuery(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow ?? throw new ArgumentNullException(nameof(uow));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public IEnumerable<ClienteModel> Execute()
        {
            IEnumerable<Cliente> clientes = _uow.Clientes.GetAll();

            return _mapper.Map<IEnumerable<Cliente>, IEnumerable<ClienteModel>>(clientes);
        }
    }
}

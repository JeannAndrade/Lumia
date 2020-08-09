using Lumia.Application.Clientes.Commands.CreateCliente.Factory;
using Lumia.Application.Interfaces;
using System;

namespace Lumia.Application.Clientes.Commands.CreateCliente
{
    public class CreateClienteCommand : ICreateClienteCommand
    {
        private readonly IUnitOfWork _uow;
        private readonly IClienteFactory _factory;

        public CreateClienteCommand(IUnitOfWork uow, IClienteFactory factory)
        {
            _uow = uow ?? throw new ArgumentNullException(nameof(uow));
            _factory = factory ?? throw new ArgumentNullException(nameof(factory));
        }

        public void Execute(CreateClienteModel model)
        {
            var cliente = _factory.Create(
                model.Nome,
                model.Telefone,
                model.Email,
                model.Endereco,
                model.Observacao
                );

            _uow.Clientes.Add(cliente);

            _uow.Complete();
        }
    }
}


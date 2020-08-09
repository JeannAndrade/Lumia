using Lumia.Domain.Clientes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lumia.Application.Clientes.Commands.CreateCliente.Factory
{
    public class ClienteFactory : IClienteFactory
    {
        public Cliente Create(string nome, string telefone, string email, string endereco, string observacao)
        {
            var cliente = new Cliente
            {
                Id = Guid.NewGuid(),
                Nome = nome,
                Telefone = telefone,
                Email = email,
                Endereco = endereco,
                Observacao = observacao
            };

            return cliente;
        }
    }
}

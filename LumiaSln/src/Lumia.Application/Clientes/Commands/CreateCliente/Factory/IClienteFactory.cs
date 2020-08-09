using Lumia.Domain.Clientes;

namespace Lumia.Application.Clientes.Commands.CreateCliente.Factory
{
    public interface IClienteFactory
    {
        Cliente Create(string nome, string telefone, string email, string endereco, string Observacao);
    }
}

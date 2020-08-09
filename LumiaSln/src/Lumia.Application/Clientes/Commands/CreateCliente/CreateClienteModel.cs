using System;
using System.Collections.Generic;
using System.Text;

namespace Lumia.Application.Clientes.Commands.CreateCliente
{
    public class CreateClienteModel
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public string Observacao { get; set; }
    }
}

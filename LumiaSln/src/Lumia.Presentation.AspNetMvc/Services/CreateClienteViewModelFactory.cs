using Lumia.Application.Clientes.Commands.CreateCliente;
using Lumia.Presentation.AspNetMvc.Models;

namespace Lumia.Presentation.AspNetMvc.Services
{
    public class CreateClienteViewModelFactory : ICreateClienteViewModelFactory
    {
        public CreateClienteViewModel Create()
        {
            var viewModel = new CreateClienteViewModel();

            viewModel.Cliente = new CreateClienteModel();

            return viewModel;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lumia.Application.Clientes.Commands.CreateCliente;
using Lumia.Application.Clientes.Queries.GetClienteList;
using Lumia.Presentation.AspNetMvc.Models;
using Lumia.Presentation.AspNetMvc.Services;
using Microsoft.AspNetCore.Mvc;

namespace Lumia.Presentation.AspNetMvc.Clientes
{
    public class ClienteController : Controller
    {
        private readonly IGetClientesListQuery _query;
        private readonly ICreateClienteViewModelFactory _factory;
        private readonly ICreateClienteCommand _createCommand;

        public ClienteController(
            IGetClientesListQuery query,
            ICreateClienteViewModelFactory factory,
            ICreateClienteCommand createCommand)
        {
            _query = query ?? throw new ArgumentNullException(nameof(query));
            _factory = factory ?? throw new ArgumentNullException(nameof(factory));
            _createCommand = createCommand ?? throw new ArgumentNullException(nameof(createCommand));
        }

        public IActionResult Index()
        {
            var clientes = _query.Execute();

            return View(clientes);
        }

        public IActionResult Create()
        {
            var viewModel = _factory.Create();

            return View(viewModel);
        }

        [HttpPost]
        public RedirectToActionResult Create(CreateClienteViewModel viewModel)
        {
            var model = viewModel.Cliente;

            _createCommand.Execute(model);

            return RedirectToAction("index", "cliente");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lumia.Application.Clientes.Queries.GetClienteList;
using Microsoft.AspNetCore.Mvc;

namespace Lumia.Presentation.AspNetMvc.Clientes
{
    public class ClienteController : Controller
    {
        private readonly IGetClientesListQuery _query;

        public ClienteController(IGetClientesListQuery query)
        {
            _query = query;
        }

        public IActionResult Index()
        {
            var clientes = _query.Execute();

            return View(clientes);
        }
    }
}

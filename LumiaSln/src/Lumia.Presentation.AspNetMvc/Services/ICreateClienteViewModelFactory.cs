using Lumia.Presentation.AspNetMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lumia.Presentation.AspNetMvc.Services
{
    public interface ICreateClienteViewModelFactory
    {
        CreateClienteViewModel Create();
    }
}

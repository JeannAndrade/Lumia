using AutoMapper;
using Lumia.Application.Clientes.Commands.CreateCliente;
using Lumia.Application.Clientes.Queries.GetClienteList;
using Lumia.Domain.Clientes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lumia.Application.Mappings
{
    public static class AutoMapperConfiguration
    {
        public static IMapper CreateMapper()
        {
            var config = new AutoMapper.MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Cliente, ClienteModel>();
            });

            config.AssertConfigurationIsValid();

            return config.CreateMapper();
        }
    }
}

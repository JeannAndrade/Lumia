using Lumia.Domain.Clientes;
using Lumia.Persistence.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lumia.Presentation.AspNetMvc
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            LumiaDbContext context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<LumiaDbContext>();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Clientes.Any())
            {
                context.Clientes.AddRange(
                    new Cliente
                    {
                        Id = Guid.NewGuid(),
                        Nome = "Jeann Marcell Silva Andrade",
                        Telefone = "21991817355",
                        Email = "jeann.andrade@gmail.com",
                        Endereco = "Rua Princesa Isabel, 407",
                        Observacao = string.Empty
                    },
                    new Cliente
                    {
                        Id = Guid.NewGuid(),
                        Nome = "Osmarina Silva Ribeiro",
                        Telefone = "218978564",
                        Email = "marina.s.ribeiro@gmail.com",
                        Endereco = "Avenida Rio Branco, 407",
                        Observacao = string.Empty
                    },
                    new Cliente
                    {
                        Id = Guid.NewGuid(),
                        Nome = "Sonia Lucia Braga",
                        Telefone = "24998753049",
                        Email = "sonia54@gmail.com",
                        Endereco = "Bairro boa sorte, 407",
                        Observacao = string.Empty
                    },
                    new Cliente
                    {
                        Id = Guid.NewGuid(),
                        Nome = "Adilson Mariano",
                        Telefone = "24998763299",
                        Email = "adilson.mariano@gmail.com",
                        Endereco = "Bairro boa sorte, 407",
                        Observacao = string.Empty
                    },
                    new Cliente
                    {
                        Id = Guid.NewGuid(),
                        Nome = "José Café Andrade",
                        Telefone = "7198984953",
                        Email = "jose.cafe@gmail.com",
                        Endereco = "Rua do Dinamico, 407",
                        Observacao = string.Empty
                    },
                    new Cliente
                    {
                        Id = Guid.NewGuid(),
                        Nome = "Paulo Andrade",
                        Telefone = "73988945423784",
                        Email = "paulo.andrade@gmail.com",
                        Endereco = "Rua do dinamico, 407",
                        Observacao = string.Empty
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
using Lumia.Application.Clientes.Queries.GetClienteList;
using Lumia.Presentation.AspNetMvc.Clientes;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lumia.Presentation.AspNetMvc.UnitTests.Clientes
{
    public class ClientesControllerTests
    {
        [Test]
        public void AberturaDaTela_RecuperarListaDeClientes_RetornaListaClientes()
        {
            // Arrange
            Guid id1 = Guid.NewGuid();
            Guid id2 = Guid.NewGuid();
            string nome1 = "Jeann Marcell Silva Andrade";
            string nome2 = "Osmarina Silva Ribeiro";

            Mock<IGetClientesListQuery> mock = new Mock<IGetClientesListQuery>();
            mock.Setup(m => m.Execute())
                .Returns(
                  (
                    new ClienteModel[] {
                        new ClienteModel { Id = id1, Nome = nome1, Telefone = "21991817355", Email = "jeann.andrade@gmail.com", Endereco = "Rua Princesa Isabel, 407", Observacao = string.Empty },
                        new ClienteModel { Id = id2, Nome = nome2, Telefone = "218978564", Email = "marina.s.ribeiro@gmail.com", Endereco = "Avenida Rio Branco, 407", Observacao = string.Empty }
                    }
                  )
                  .AsEnumerable<ClienteModel>()
                );

            ClienteController controller = new ClienteController(mock.Object);

            // Act
            IEnumerable<ClienteModel> result = (controller.Index() as ViewResult)?.ViewData.Model as IEnumerable<ClienteModel>;

            // Assert
            ClienteModel[] prodArray = result.ToArray();
            Assert.True(prodArray.Length == 2);
            Assert.That(id1, Is.EqualTo(prodArray[0].Id));
            Assert.That(id2, Is.EqualTo(prodArray[1].Id));
            Assert.That(nome1, Is.EqualTo(prodArray[0].Nome));
            Assert.That(nome2, Is.EqualTo(prodArray[1].Nome));
        }
    }
}
using Lumia.Application.Clientes.Queries.GetClienteList;
using Lumia.Application.Interfaces;
using Lumia.Common.Mocks;
using Lumia.Domain.Clientes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lumia.Application.UnitTests.Clientes.Queries.GetClientesList
{
    public class GetClientesListQueryTests
    {
        private GetClientesListQuery _query;
        private Cliente _cliente;

        private Guid Id = Guid.NewGuid();
        private const string Name = "Customer 1";
        private const string Telefone = "21991817355";
        private const string Endereco = "Rua Princesa Isabel";
        private const string Observacao = "Alguma observacao";
        private const string Email = "jeann.andrade@gmail.com";

        [SetUp]
        public void SetUp()
        {
            //_mocker = new AutoMoqer();

            //_cliente = new Cliente()
            //{
            //    Id = Id,
            //    Nome = Name,
            //    Telefone = Telefone,
            //    Endereco = Endereco,
            //    Email = Email,
            //    Observacao = Observacao
            //};

            //_mocker.GetMock<IQueryable<Cliente>>()
            //    .SetUpDbSet(new List<Cliente> { _cliente });

            //_mocker.GetMock<IDatabaseService>()
            //    .Setup(p => p.Clientes)
            //    .Returns(_mocker.GetMock<IQueryable<Cliente>>().Object);

            //_query = _mocker.Create<GetClientesListQuery>();
        }

        [Test]
        [Ignore("Até que eu descubra como implementar isso sem o AutoMoqer")]
        public void TestExecuteShouldReturnListOfCustomers()
        {
            var results = _query.Execute();

            var result = results.Single();

            Assert.That(result.Id, Is.EqualTo(Id));
            Assert.That(result.Nome, Is.EqualTo(Name));
            Assert.That(result.Telefone, Is.EqualTo(Telefone));
            Assert.That(result.Endereco, Is.EqualTo(Endereco));
            Assert.That(result.Email, Is.EqualTo(Email));
            Assert.That(result.Observacao, Is.EqualTo(Observacao));
        }
    }
}

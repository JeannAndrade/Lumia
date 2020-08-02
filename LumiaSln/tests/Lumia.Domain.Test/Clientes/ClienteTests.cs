using Lumia.Domain.Clientes;
using NUnit.Framework;
using System;

namespace Lumia.Domain.UnitTests.Clientes
{
    internal class ClienteTests
    {
        private readonly Cliente _cliente;

        public ClienteTests()
        {
            _cliente = new Cliente();
        }

        [Test]
        public void PropriedadeId_SetadoComUmNovoGuid_RetornarOMesmoGuid()
        {
            Guid novoId = Guid.NewGuid();

            _cliente.Id = novoId;

            Assert.That(_cliente.Id, Is.EqualTo(novoId));
        }

        [Test]
        public void PropriedadeNome_SetadoComUmNovoValor_RetornarOMesmoValor()
        {
            const string novoValor = "Jeann Andrade";

            _cliente.Nome = novoValor;

            Assert.That(_cliente.Nome, Is.EqualTo(novoValor));
        }

        [Test]
        public void PropriedadeTelefone_SetadoComUmNovoValor_RetornarOMesmoValor()
        {
            const string novoValor = "21991817355";

            _cliente.Telefone = novoValor;

            Assert.That(_cliente.Telefone, Is.EqualTo(novoValor));
        }

        [Test]
        public void PropriedadeEmail_SetadoComUmNovoValor_RetornarOMesmoValor()
        {
            const string novoValor = "jeann.andrade@gmail.com";

            _cliente.Email = novoValor;

            Assert.That(_cliente.Email, Is.EqualTo(novoValor));
        }

        [Test]
        public void PropriedadeEndereco_SetadoComUmNovoValor_RetornarOMesmoValor()
        {
            const string novoValor = "Rua Princesa Isabel";

            _cliente.Endereco = novoValor;

            Assert.That(_cliente.Endereco, Is.EqualTo(novoValor));
        }

        [Test]
        public void PropriedadeObservacao_SetadoComUmNovoValor_RetornarOMesmoValor()
        {
            const string novoValor = "Este cliente não costuma pagar no prazo";

            _cliente.Observacao = novoValor;

            Assert.That(_cliente.Observacao, Is.EqualTo(novoValor));
        }
    }
}

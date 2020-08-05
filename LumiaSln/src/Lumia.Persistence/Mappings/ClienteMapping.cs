using Lumia.Domain.Clientes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lumia.Persistence.Mappings
{
    public class ClienteMapping : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Clientes");
            builder.HasKey(k => k.Id);
            builder.Property(e => e.Nome).HasMaxLength(150).IsRequired();
            builder.Property(e => e.Email).HasMaxLength(150);
            builder.Property(e => e.Endereco).HasMaxLength(250);
            builder.Property(e => e.Telefone).HasMaxLength(15);
            builder.Property(e => e.Observacao).HasMaxLength(1000);

            //builder.Ignore(e => e.ValidationResult);

            //builder.Ignore(e => e.Tags);

            //builder.Ignore(e => e.CascadeMode);

            //builder.HasOne(e => e.Organizador)
            //    .WithMany(o => o.Eventos)
            //    .HasForeignKey(e => e.OrganizadorId);

            //builder.HasOne(e => e.Categoria)
            //    .WithMany(e => e.Eventos)
            //    .HasForeignKey(e => e.CategoriaId)
            //    .IsRequired(false);
        }
    }
}

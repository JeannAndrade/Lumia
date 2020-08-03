using Lumia.Domain.Clientes;
using Lumia.Persistence.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lumia.Persistence.Mappings
{
    public class ClienteMapping : EntityTypeConfiguration<Cliente>
    {
        public override void Map(EntityTypeBuilder<Cliente> builder)
        {
            builder.Property(e => e.Nome)
               .HasColumnType("varchar(150)")
               .IsRequired();

            builder.Property(e => e.Email)
                .HasColumnType("varchar(150)");

            builder.Property(e => e.Endereco)
                .HasColumnType("varchar(250)");

            builder.Property(e => e.Telefone)
                .HasColumnType("varchar(15)");

            builder.Property(e => e.Observacao)
                .HasColumnType("varchar(1000)");

            //builder.Ignore(e => e.ValidationResult);

            //builder.Ignore(e => e.Tags);

            //builder.Ignore(e => e.CascadeMode);

            //builder.ToTable("Eventos");

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

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lumia.Persistence.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(maxLength: 150, nullable: false),
                    Telefone = table.Column<string>(maxLength: 15, nullable: true),
                    Email = table.Column<string>(maxLength: 150, nullable: true),
                    Endereco = table.Column<string>(maxLength: 250, nullable: true),
                    Observacao = table.Column<string>(maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PagamentoData.Migrations
{
    public partial class banco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DetalhesPagamento",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NomeDonoCartao = table.Column<string>(type: "varchar(100)", nullable: false),
                    NumeroCartao = table.Column<string>(type: "varchar(14)", nullable: false),
                    DataExpiracao = table.Column<DateTime>(type: "datetime", nullable: false),
                    CodigoSeguranca = table.Column<string>(type: "varchar(50)", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalhesPagamento", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetalhesPagamento");
        }
    }
}

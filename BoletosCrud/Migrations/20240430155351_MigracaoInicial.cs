using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BoletosCrud.Migrations
{
    public partial class MigracaoInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BANCO",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NomeDoBanco = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    CodigoDoBanco = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    PercentualDeJuros = table.Column<decimal>(type: "numeric(3,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BANCO", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BOLETO",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NomePagador = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    DocumentoPagador = table.Column<string>(type: "character varying(14)", maxLength: 14, nullable: false),
                    NomeBeneficiario = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    DocumentoBeneficiario = table.Column<string>(type: "character varying(14)", maxLength: 14, nullable: false),
                    Valor = table.Column<decimal>(type: "numeric(6,2)", nullable: false),
                    DataVencimento = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Observacao = table.Column<string>(type: "text", nullable: false),
                    BancoId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BOLETO", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BOLETO_BANCO_BancoId",
                        column: x => x.BancoId,
                        principalTable: "BANCO",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BOLETO_BancoId",
                table: "BOLETO",
                column: "BancoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BOLETO");

            migrationBuilder.DropTable(
                name: "BANCO");
        }
    }
}

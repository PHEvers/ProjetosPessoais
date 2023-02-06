using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CadastroDeEmpresas.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class Teste : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UF",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UF", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Empresa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UfId = table.Column<int>(type: "int", nullable: false),
                    NomeFantasia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmpesaCNPJ = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresa", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Empresa_UF_UfId",
                        column: x => x.UfId,
                        principalTable: "UF",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Fornecedor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpresaId = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CPFCNPJ = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RG = table.Column<int>(type: "int", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fornecedor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fornecedor_Empresa_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "UF",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { 1, "AC" },
                    { 2, "AL" },
                    { 3, "AP" },
                    { 4, "AM" },
                    { 5, "BA" },
                    { 6, "CE" },
                    { 7, "ES" },
                    { 8, "GO" },
                    { 9, "MA" },
                    { 10, "MT" },
                    { 11, "MS" },
                    { 12, "MG" },
                    { 13, "PA" },
                    { 14, "PB" },
                    { 15, "PR" },
                    { 16, "PE" },
                    { 17, "PI" },
                    { 18, "RJ" },
                    { 19, "RN" },
                    { 20, "RS" },
                    { 21, "RO" },
                    { 22, "RR" },
                    { 23, "SC" },
                    { 24, "SP" },
                    { 25, "SE" },
                    { 26, "TO" },
                    { 27, "DF" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Empresa_UfId",
                table: "Empresa",
                column: "UfId");

            migrationBuilder.CreateIndex(
                name: "IX_Fornecedor_EmpresaId",
                table: "Fornecedor",
                column: "EmpresaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fornecedor");

            migrationBuilder.DropTable(
                name: "Empresa");

            migrationBuilder.DropTable(
                name: "UF");
        }
    }
}

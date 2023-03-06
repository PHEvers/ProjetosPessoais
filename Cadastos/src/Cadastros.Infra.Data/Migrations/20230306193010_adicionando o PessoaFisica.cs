using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cadastros.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class adicionandooPessoaFisica : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RG",
                table: "Fornecedor",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<bool>(
                name: "PessoaFisica",
                table: "Fornecedor",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PessoaFisica",
                table: "Fornecedor");

            migrationBuilder.AlterColumn<string>(
                name: "RG",
                table: "Fornecedor",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}

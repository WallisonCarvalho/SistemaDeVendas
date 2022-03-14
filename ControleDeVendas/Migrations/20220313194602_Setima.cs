using Microsoft.EntityFrameworkCore.Migrations;

namespace ControleDeVendas.Migrations
{
    public partial class Setima : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Venda_ProdutoId",
                table: "Venda");

            migrationBuilder.DropIndex(
                name: "IX_Venda_VendedorId",
                table: "Venda");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Vendedor");

            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Produto");

            migrationBuilder.CreateIndex(
                name: "IX_Venda_ProdutoId",
                table: "Venda",
                column: "ProdutoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Venda_VendedorId",
                table: "Venda",
                column: "VendedorId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Venda_ProdutoId",
                table: "Venda");

            migrationBuilder.DropIndex(
                name: "IX_Venda_VendedorId",
                table: "Venda");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Vendedor",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Produto",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Venda_ProdutoId",
                table: "Venda",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_Venda_VendedorId",
                table: "Venda",
                column: "VendedorId");
        }
    }
}

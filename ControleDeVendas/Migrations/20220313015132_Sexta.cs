using Microsoft.EntityFrameworkCore.Migrations;

namespace ControleDeVendas.Migrations
{
    public partial class Sexta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produto_Estoque_EstoqueId",
                table: "Produto");

            migrationBuilder.DropIndex(
                name: "IX_Produto_EstoqueId",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "EstoqueId",
                table: "Produto");

            migrationBuilder.AddColumn<int>(
                name: "ProdutoId",
                table: "Estoque",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Estoque_ProdutoId",
                table: "Estoque",
                column: "ProdutoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Estoque_Produto_ProdutoId",
                table: "Estoque",
                column: "ProdutoId",
                principalTable: "Produto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estoque_Produto_ProdutoId",
                table: "Estoque");

            migrationBuilder.DropIndex(
                name: "IX_Estoque_ProdutoId",
                table: "Estoque");

            migrationBuilder.DropColumn(
                name: "ProdutoId",
                table: "Estoque");

            migrationBuilder.AddColumn<int>(
                name: "EstoqueId",
                table: "Produto",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Produto_EstoqueId",
                table: "Produto",
                column: "EstoqueId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produto_Estoque_EstoqueId",
                table: "Produto",
                column: "EstoqueId",
                principalTable: "Estoque",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

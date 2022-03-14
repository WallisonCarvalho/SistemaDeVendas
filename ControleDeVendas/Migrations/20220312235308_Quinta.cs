using Microsoft.EntityFrameworkCore.Migrations;

namespace ControleDeVendas.Migrations
{
    public partial class Quinta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Venda_Produto_ProdutoId",
                table: "Venda");

            migrationBuilder.DropForeignKey(
                name: "FK_Venda_Vendedor_VendedorId",
                table: "Venda");

            migrationBuilder.AlterColumn<int>(
                name: "VendedorId",
                table: "Venda",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProdutoId",
                table: "Venda",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Venda_Produto_ProdutoId",
                table: "Venda",
                column: "ProdutoId",
                principalTable: "Produto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Venda_Vendedor_VendedorId",
                table: "Venda",
                column: "VendedorId",
                principalTable: "Vendedor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Venda_Produto_ProdutoId",
                table: "Venda");

            migrationBuilder.DropForeignKey(
                name: "FK_Venda_Vendedor_VendedorId",
                table: "Venda");

            migrationBuilder.AlterColumn<int>(
                name: "VendedorId",
                table: "Venda",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ProdutoId",
                table: "Venda",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Venda_Produto_ProdutoId",
                table: "Venda",
                column: "ProdutoId",
                principalTable: "Produto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Venda_Vendedor_VendedorId",
                table: "Venda",
                column: "VendedorId",
                principalTable: "Vendedor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

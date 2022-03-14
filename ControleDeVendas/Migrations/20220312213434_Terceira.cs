using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ControleDeVendas.Migrations
{
    public partial class Terceira : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EstoqueId",
                table: "Produto",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Estoque",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    Qtde = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estoque", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produto_Estoque_EstoqueId",
                table: "Produto");

            migrationBuilder.DropTable(
                name: "Estoque");

            migrationBuilder.DropIndex(
                name: "IX_Produto_EstoqueId",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "EstoqueId",
                table: "Produto");
        }
    }
}

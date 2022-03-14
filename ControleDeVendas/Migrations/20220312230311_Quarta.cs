using Microsoft.EntityFrameworkCore.Migrations;

namespace ControleDeVendas.Migrations
{
    public partial class Quarta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "QtdeVenda",
                table: "Venda",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QtdeVenda",
                table: "Venda");
        }
    }
}

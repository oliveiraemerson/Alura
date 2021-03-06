using Microsoft.EntityFrameworkCore.Migrations;

namespace CasaDoCodigo.Migrations
{
    public partial class Pedido_ClienteId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ClientId",
                table: "Pedido",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Pedido");
        }
    }
}

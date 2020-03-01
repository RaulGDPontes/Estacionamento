using Microsoft.EntityFrameworkCore.Migrations;

namespace TesteEstacionamento.Migrations
{
    public partial class ajustes2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Valor",
                table: "Clientes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Valor",
                table: "Clientes");
        }
    }
}

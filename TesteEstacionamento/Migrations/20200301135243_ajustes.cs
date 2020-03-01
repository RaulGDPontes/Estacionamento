using Microsoft.EntityFrameworkCore.Migrations;

namespace TesteEstacionamento.Migrations
{
    public partial class ajustes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "HoraSaida",
                table: "Clientes",
                newName: "DataSaida");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DataSaida",
                table: "Clientes",
                newName: "HoraSaida");
        }
    }
}

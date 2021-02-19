using Microsoft.EntityFrameworkCore.Migrations;

namespace AvaliacaoEntrevistaAudrey2.Migrations
{
    public partial class AdicionandoCampos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Equipamentos",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Equipamentos");
        }
    }
}

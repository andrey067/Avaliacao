using Microsoft.EntityFrameworkCore.Migrations;

namespace AvaliacaoEntrevistaAudrey2.Migrations
{
    public partial class AltPropriedades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Situacao",
                table: "Equipamentos");

            migrationBuilder.DropColumn(
                name: "UfDestino",
                table: "Equipamentos");

            migrationBuilder.DropColumn(
                name: "UfOrigem",
                table: "Equipamentos");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Equipamentos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IdentificadorEquipamento",
                table: "Equipamentos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SituacaoId",
                table: "Equipamentos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UfDestinoId",
                table: "Equipamentos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UfOrigemId",
                table: "Equipamentos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Situacao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ativo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cacelado = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Situacao", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Equipamentos_SituacaoId",
                table: "Equipamentos",
                column: "SituacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipamentos_UfDestinoId",
                table: "Equipamentos",
                column: "UfDestinoId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipamentos_UfOrigemId",
                table: "Equipamentos",
                column: "UfOrigemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipamentos_Estados_UfDestinoId",
                table: "Equipamentos",
                column: "UfDestinoId",
                principalTable: "Estados",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Equipamentos_Estados_UfOrigemId",
                table: "Equipamentos",
                column: "UfOrigemId",
                principalTable: "Estados",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Equipamentos_Situacao_SituacaoId",
                table: "Equipamentos",
                column: "SituacaoId",
                principalTable: "Situacao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipamentos_Estados_UfDestinoId",
                table: "Equipamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Equipamentos_Estados_UfOrigemId",
                table: "Equipamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Equipamentos_Situacao_SituacaoId",
                table: "Equipamentos");

            migrationBuilder.DropTable(
                name: "Situacao");

            migrationBuilder.DropIndex(
                name: "IX_Equipamentos_SituacaoId",
                table: "Equipamentos");

            migrationBuilder.DropIndex(
                name: "IX_Equipamentos_UfDestinoId",
                table: "Equipamentos");

            migrationBuilder.DropIndex(
                name: "IX_Equipamentos_UfOrigemId",
                table: "Equipamentos");

            migrationBuilder.DropColumn(
                name: "SituacaoId",
                table: "Equipamentos");

            migrationBuilder.DropColumn(
                name: "UfDestinoId",
                table: "Equipamentos");

            migrationBuilder.DropColumn(
                name: "UfOrigemId",
                table: "Equipamentos");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Equipamentos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "IdentificadorEquipamento",
                table: "Equipamentos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<bool>(
                name: "Situacao",
                table: "Equipamentos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UfDestino",
                table: "Equipamentos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UfOrigem",
                table: "Equipamentos",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}

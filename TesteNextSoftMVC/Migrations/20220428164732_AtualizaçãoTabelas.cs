using Microsoft.EntityFrameworkCore.Migrations;

namespace TesteNextSoftMVC.Migrations
{
    public partial class AtualizaçãoTabelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "AreaApto",
                table: "Familia",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "FracaoIdeal",
                table: "Familia",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ValorIPTU_Proporcional",
                table: "Familia",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "AreaTotalCondominio",
                table: "Condominio",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ValorIPTU",
                table: "Condominio",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AreaApto",
                table: "Familia");

            migrationBuilder.DropColumn(
                name: "FracaoIdeal",
                table: "Familia");

            migrationBuilder.DropColumn(
                name: "ValorIPTU_Proporcional",
                table: "Familia");

            migrationBuilder.DropColumn(
                name: "AreaTotalCondominio",
                table: "Condominio");

            migrationBuilder.DropColumn(
                name: "ValorIPTU",
                table: "Condominio");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace TesteNextSoftMVC.Migrations
{
    public partial class CriacaoTabelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Condominio",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: true),
                    Bairro = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Condominio", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Familia",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: true),
                    Id_Condominio = table.Column<int>(nullable: false),
                    Apto = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Familia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Familia_Condominio_Id_Condominio",
                        column: x => x.Id_Condominio,
                        principalTable: "Condominio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Morador",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Familia = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    Idade = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Morador", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Morador_Familia_Id_Familia",
                        column: x => x.Id_Familia,
                        principalTable: "Familia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Familia_Id_Condominio",
                table: "Familia",
                column: "Id_Condominio");

            migrationBuilder.CreateIndex(
                name: "IX_Morador_Id_Familia",
                table: "Morador",
                column: "Id_Familia");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Morador");

            migrationBuilder.DropTable(
                name: "Familia");

            migrationBuilder.DropTable(
                name: "Condominio");
        }
    }
}

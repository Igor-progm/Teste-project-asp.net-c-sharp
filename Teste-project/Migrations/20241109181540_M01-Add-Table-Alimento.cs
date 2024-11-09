using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Teste_project.Migrations
{
    /// <inheritdoc />
    public partial class M01AddTableAlimento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alimentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Calorias = table.Column<int>(type: "int", nullable: false),
                    Caorboidratos = table.Column<int>(type: "int", nullable: false),
                    AcucaresTotais = table.Column<int>(type: "int", nullable: false),
                    Proteinas = table.Column<int>(type: "int", nullable: false),
                    GordurasSaturadas = table.Column<int>(type: "int", nullable: false),
                    FibrasAlimentares = table.Column<int>(type: "int", nullable: false),
                    Sodio = table.Column<int>(type: "int", nullable: false),
                    VitaminaB1 = table.Column<int>(type: "int", nullable: false),
                    VitaminaB2 = table.Column<int>(type: "int", nullable: false),
                    VitaminaB6 = table.Column<int>(type: "int", nullable: false),
                    Calcio = table.Column<int>(type: "int", nullable: false),
                    Ferro = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alimentos", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alimentos");
        }
    }
}

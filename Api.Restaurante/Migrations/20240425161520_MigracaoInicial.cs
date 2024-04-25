using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api.Restaurante.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pratos",
                columns: table => new
                {
                    PratoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PratoNome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PratoDescricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PratoValorUnit = table.Column<double>(type: "float", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pratos", x => x.PratoId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pratos");
        }
    }
}

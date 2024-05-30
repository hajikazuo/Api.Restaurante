using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api.Restaurante.Migrations
{
    /// <inheritdoc />
    public partial class PopulaPratos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Pratos (PratoNome, PratoDescricao, PratoValorUnit, UrlImg, Ativo) VALUES ('Feijoada', 'Feijoada completa com acompanhamentos.', 25.00, 'url_da_imagem_feijoada', 1)");
            migrationBuilder.Sql("INSERT INTO Pratos (PratoNome, PratoDescricao, PratoValorUnit, UrlImg, Ativo) VALUES ('Bife à Parmegiana', 'Bife à parmegiana com arroz e fritas.', 20.00, 'url_da_imagem_parmegiana', 1)");
            migrationBuilder.Sql("INSERT INTO Pratos (PratoNome, PratoDescricao, PratoValorUnit, UrlImg, Ativo) VALUES ('Moqueca de Peixe', 'Moqueca de peixe com pirão e arroz.', 30.00, 'url_da_imagem_moqueca', 1)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Pratos WHERE PratoNome = 'Feijoada'");
            migrationBuilder.Sql("DELETE FROM Pratos WHERE PratoNome = 'Bife à Parmegiana'");
            migrationBuilder.Sql("DELETE FROM Pratos WHERE PratoNome = 'Moqueca de Peixe'");
        }
    }
}

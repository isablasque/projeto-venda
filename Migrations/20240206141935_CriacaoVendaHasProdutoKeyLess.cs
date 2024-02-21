using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoVendas2.Migrations
{
    /// <inheritdoc />
    public partial class CriacaoVendaHasProdutoKeyLess : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VendaHasProduto",
                columns: table => new
                {
                    VendaId = table.Column<int>(type: "int", nullable: false),
                    ProdutoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_VendaHasProduto_Produto_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VendaHasProduto_Venda_VendaId",
                        column: x => x.VendaId,
                        principalTable: "Venda",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VendaHasProduto_ProdutoId",
                table: "VendaHasProduto",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_VendaHasProduto_VendaId",
                table: "VendaHasProduto",
                column: "VendaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VendaHasProduto");
        }
    }
}

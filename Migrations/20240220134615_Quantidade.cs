using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoVendas2.Migrations
{
    /// <inheritdoc />
    public partial class Quantidade : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VendaHasQuantidade",
                table: "VendaHasProduto",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VendaHasQuantidade",
                table: "VendaHasProduto");
        }
    }
}

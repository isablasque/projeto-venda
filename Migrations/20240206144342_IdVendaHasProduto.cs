using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoVendas2.Migrations
{
    /// <inheritdoc />
    public partial class IdVendaHasProduto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "VendaHasProduto",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VendaHasProduto",
                table: "VendaHasProduto",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_VendaHasProduto",
                table: "VendaHasProduto");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "VendaHasProduto");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace BancoDigital.Migrations
{
    public partial class RelacionamentoAutorClientes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AutorId",
                table: "Clientes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_AutorId",
                table: "Clientes",
                column: "AutorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Usuarios_AutorId",
                table: "Clientes",
                column: "AutorId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Usuarios_AutorId",
                table: "Clientes");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_AutorId",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "AutorId",
                table: "Clientes");
        }
    }
}

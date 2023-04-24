using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GG_Examen.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GGuevara",
                columns: table => new
                {
                    gg_Codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    gg_Nombre = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    gg_EnStock = table.Column<bool>(type: "bit", nullable: false),
                    gg_Precio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    gg_FechaCaducidad = table.Column<DateTime>(type: "datetime2", nullable: false),
                    gg_CorreoClienteQueAdquirioProducto = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GGuevara", x => x.gg_Codigo);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GGuevara");
        }
    }
}

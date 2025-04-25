using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharpPonto25.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Registros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data = table.Column<DateOnly>(type: "date", nullable: false),
                    Entrada = table.Column<TimeOnly>(type: "time", nullable: false),
                    Almoco = table.Column<TimeOnly>(type: "time", nullable: false),
                    Retorno = table.Column<TimeOnly>(type: "time", nullable: false),
                    Saida = table.Column<TimeOnly>(type: "time", nullable: false),
                    Manha = table.Column<TimeOnly>(type: "time", nullable: false),
                    Tarde = table.Column<TimeOnly>(type: "time", nullable: false),
                    TotalDia = table.Column<TimeOnly>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registros", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Registros");
        }
    }
}

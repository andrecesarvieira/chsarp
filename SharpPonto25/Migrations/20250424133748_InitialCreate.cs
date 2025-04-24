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
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Data = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    Entrada = table.Column<TimeOnly>(type: "TEXT", nullable: false),
                    Almoco = table.Column<TimeOnly>(type: "TEXT", nullable: false),
                    Retorno = table.Column<TimeOnly>(type: "TEXT", nullable: false),
                    Saida = table.Column<TimeOnly>(type: "TEXT", nullable: false),
                    Manha = table.Column<TimeOnly>(type: "TEXT", nullable: false),
                    Tarde = table.Column<TimeOnly>(type: "TEXT", nullable: false),
                    TotalDia = table.Column<TimeOnly>(type: "TEXT", nullable: false)
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

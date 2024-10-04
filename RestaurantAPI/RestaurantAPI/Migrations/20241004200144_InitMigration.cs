using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurantAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "restauracja",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Imie = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Nazwisko = table.Column<string>(type: "nvarchar(55)", maxLength: 55, nullable: false),
                    Nazwa = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    Opis = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumerTelRestauracji = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    NumerTelDoZamowien = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kategoria = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CzyDostawa = table.Column<bool>(type: "bit", nullable: false),
                    Zdjecie = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_restauracja", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "adresRestauracji",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Miasto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ulica = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KodPocztowy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RestauracjaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_adresRestauracji", x => x.Id);
                    table.ForeignKey(
                        name: "FK_adresRestauracji_restauracja_RestauracjaId",
                        column: x => x.RestauracjaId,
                        principalTable: "restauracja",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_adresRestauracji_RestauracjaId",
                table: "adresRestauracji",
                column: "RestauracjaId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "adresRestauracji");

            migrationBuilder.DropTable(
                name: "restauracja");
        }
    }
}

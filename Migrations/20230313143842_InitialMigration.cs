using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace urlopy2.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pracownicy",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tekst = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataOd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataDo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IleDni = table.Column<int>(type: "int", nullable: false),
                    JestAkceptacja = table.Column<bool>(type: "bit", nullable: false),
                    ZdjecieUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MiniaturkaUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    data_created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    data_updated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pracownicy", x => x.Id);
                });
        }

        /// <inheritdoc />
        //protected override void Down(MigrationBuilder migrationBuilder)
        //{
        //    migrationBuilder.DropTable(
        //        name: "Pracownicy");
        //}
    }
}

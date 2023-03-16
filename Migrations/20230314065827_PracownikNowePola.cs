using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace urlopy2.Migrations
{
    /// <inheritdoc />
    public partial class PracownikNowePola : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "JsetZgoda",
                table: "Pracownicy",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Manager",
                table: "Pracownicy",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        //protected override void Down(MigrationBuilder migrationBuilder)
        //{
        //    migrationBuilder.DropColumn(
        //        name: "JsetZgoda",
        //        table: "Pracownicy");
        //
        //    migrationBuilder.DropColumn(
        //        name: "Manager",
        //        table: "Pracownicy");
        //}
    }
}

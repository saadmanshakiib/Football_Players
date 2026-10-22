using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FootballClub.Migrations
{
    /// <inheritdoc />
    public partial class secondcreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "age",
                table: "players",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "currentClub",
                table: "players",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "name",
                table: "players",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "position",
                table: "players",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "age",
                table: "players");

            migrationBuilder.DropColumn(
                name: "currentClub",
                table: "players");

            migrationBuilder.DropColumn(
                name: "name",
                table: "players");

            migrationBuilder.DropColumn(
                name: "position",
                table: "players");
        }
    }
}

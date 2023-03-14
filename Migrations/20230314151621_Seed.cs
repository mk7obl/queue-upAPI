using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace queueUp.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Games",
                newName: "Rank");

            migrationBuilder.AlterColumn<string>(
                name: "NickName",
                table: "PlayerProfiles",
                type: "nvarchar(16)",
                maxLength: 16,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "GameId",
                table: "PlayerProfiles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "GameDescription",
                table: "Games",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GameTitle",
                table: "Games",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Position",
                table: "Games",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GameId",
                table: "PlayerProfiles");

            migrationBuilder.DropColumn(
                name: "GameDescription",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "GameTitle",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "Position",
                table: "Games");

            migrationBuilder.RenameColumn(
                name: "Rank",
                table: "Games",
                newName: "Title");

            migrationBuilder.AlterColumn<string>(
                name: "NickName",
                table: "PlayerProfiles",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(16)",
                oldMaxLength: 16);
        }
    }
}

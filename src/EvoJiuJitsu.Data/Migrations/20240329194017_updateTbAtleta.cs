using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EvoJiuJitsu.Data.Migrations
{
    public partial class updateTbAtleta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Polo",
                table: "Atletas",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Polo",
                table: "Atletas");
        }
    }
}

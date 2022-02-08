using Microsoft.EntityFrameworkCore.Migrations;

namespace Airline_Management_CF.Migrations
{
    public partial class ac : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Isactive",
                table: "User",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "FlightNumber1",
                table: "FlightInfo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "isactive",
                table: "FlightInfo",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_FlightInfo_FlightNumber1",
                table: "FlightInfo",
                column: "FlightNumber1");

            migrationBuilder.AddForeignKey(
                name: "FK_FlightInfo_FlightDetails_FlightNumber1",
                table: "FlightInfo",
                column: "FlightNumber1",
                principalTable: "FlightDetails",
                principalColumn: "FlightNumber",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlightInfo_FlightDetails_FlightNumber1",
                table: "FlightInfo");

            migrationBuilder.DropIndex(
                name: "IX_FlightInfo_FlightNumber1",
                table: "FlightInfo");

            migrationBuilder.DropColumn(
                name: "Isactive",
                table: "User");

            migrationBuilder.DropColumn(
                name: "FlightNumber1",
                table: "FlightInfo");

            migrationBuilder.DropColumn(
                name: "isactive",
                table: "FlightInfo");
        }
    }
}

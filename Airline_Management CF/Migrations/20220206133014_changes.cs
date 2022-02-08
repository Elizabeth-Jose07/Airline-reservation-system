using Microsoft.EntityFrameworkCore.Migrations;

namespace Airline_Management_CF.Migrations
{
    public partial class changes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlightInfo_FlightDetails_FlightNumber1",
                table: "FlightInfo");

            migrationBuilder.DropIndex(
                name: "IX_FlightInfo_FlightNumber1",
                table: "FlightInfo");

            migrationBuilder.DropColumn(
                name: "FlightNumber1",
                table: "FlightInfo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FlightNumber1",
                table: "FlightInfo",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
    }
}

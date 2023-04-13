using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BikeRentalSystem.Migrations
{
    /// <inheritdoc />
    public partial class tworzenie_bazy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rents",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    rentStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    rentStop = table.Column<DateTime>(type: "datetime2", nullable: false),
                    vehicleId = table.Column<int>(type: "int", nullable: false),
                    firstNameDriver = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    secondNameDriver = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    emailDriver = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumberDriver = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rents", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Wheel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HourlyPrize = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bike_Size = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Electric = table.Column<bool>(type: "bit", nullable: true),
                    Hight = table.Column<int>(type: "int", nullable: true),
                    Size = table.Column<int>(type: "int", nullable: true),
                    WheelHardness = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rents");

            migrationBuilder.DropTable(
                name: "Vehicles");
        }
    }
}

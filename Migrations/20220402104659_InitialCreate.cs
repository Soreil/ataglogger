using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace gas.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "States",
                columns: table => new
                {
                    latestReportTime = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    deviceIP = table.Column<string>(type: "TEXT", nullable: false),
                    deviceId = table.Column<string>(type: "TEXT", nullable: false),
                    burningHours = table.Column<double>(type: "REAL", nullable: false),
                    roomTemperature = table.Column<double>(type: "REAL", nullable: false),
                    outsideTemperature = table.Column<double>(type: "REAL", nullable: false),
                    dhwSetpoint = table.Column<double>(type: "REAL", nullable: false),
                    dhwWaterTemperature = table.Column<double>(type: "REAL", nullable: false),
                    chSetpoint = table.Column<double>(type: "REAL", nullable: false),
                    chWaterTemperature = table.Column<double>(type: "REAL", nullable: false),
                    chWaterPressure = table.Column<double>(type: "REAL", nullable: false),
                    chReturnTemperature = table.Column<double>(type: "REAL", nullable: false),
                    targetTemperature = table.Column<double>(type: "REAL", nullable: false),
                    deviceStatus = table.Column<int>(type: "INTEGER", nullable: false),
                    connectionStatus = table.Column<int>(type: "INTEGER", nullable: false),
                    deviceErrors = table.Column<string>(type: "TEXT", nullable: false),
                    boilerErrors = table.Column<string>(type: "TEXT", nullable: false),
                    dbgOutsideTemp = table.Column<double>(type: "REAL", nullable: false),
                    pcbTemp = table.Column<double>(type: "REAL", nullable: false),
                    dhwWaterTemp = table.Column<double>(type: "REAL", nullable: false),
                    dhwWaterPres = table.Column<double>(type: "REAL", nullable: false),
                    boilerStatus = table.Column<int>(type: "INTEGER", nullable: false),
                    boilerConfig = table.Column<int>(type: "INTEGER", nullable: false),
                    chTimeToTemp = table.Column<double>(type: "REAL", nullable: false),
                    powerCons = table.Column<double>(type: "REAL", nullable: false),
                    rssi = table.Column<int>(type: "INTEGER", nullable: false),
                    current = table.Column<double>(type: "REAL", nullable: false),
                    voltage = table.Column<double>(type: "REAL", nullable: false),
                    resets = table.Column<int>(type: "INTEGER", nullable: false),
                    memoryAllocation = table.Column<int>(type: "INTEGER", nullable: false),
                    chStatus = table.Column<int>(type: "INTEGER", nullable: false),
                    chControl_mode = table.Column<int>(type: "INTEGER", nullable: false),
                    chMode = table.Column<int>(type: "INTEGER", nullable: false),
                    chModeDuration = table.Column<double>(type: "REAL", nullable: false),
                    chModeTemp = table.Column<double>(type: "REAL", nullable: false),
                    dhwStatus = table.Column<int>(type: "INTEGER", nullable: false),
                    dhwMode = table.Column<int>(type: "INTEGER", nullable: false),
                    weatherTemp = table.Column<double>(type: "REAL", nullable: false),
                    weatherStatus = table.Column<int>(type: "INTEGER", nullable: false),
                    vacationDuration = table.Column<double>(type: "REAL", nullable: false),
                    extendDuration = table.Column<double>(type: "REAL", nullable: false),
                    fireplaceDuration = table.Column<double>(type: "REAL", nullable: false),
                    flameStatus = table.Column<string>(type: "TEXT", nullable: false),
                    atagOneVersion = table.Column<string>(type: "TEXT", nullable: false),
                    macAddress = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_States", x => x.latestReportTime);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "States");
        }
    }
}

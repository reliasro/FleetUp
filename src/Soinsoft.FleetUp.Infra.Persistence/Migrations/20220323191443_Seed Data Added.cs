using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Soinsoft.FleetUp.Infra.Persistence.Migrations
{
    public partial class SeedDataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "Id", "Color", "CreatedOn", "CurrentValue", "Description", "Make", "Model", "VIN", "Year" },
                values: new object[] { 1, "Blue", new DateTime(2022, 3, 23, 0, 0, 0, 0, DateTimeKind.Local), 555m, "For Production", "Honda", "Masda", "A55-522", "2020" });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "Id", "Color", "CreatedOn", "CurrentValue", "Description", "Make", "Model", "VIN", "Year" },
                values: new object[] { 2, "Blue", new DateTime(2022, 3, 23, 0, 0, 0, 0, DateTimeKind.Local), 555m, "For Sales Department", "Honda", "Masda", "F5588", "2020" });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "Id", "Color", "CreatedOn", "CurrentValue", "Description", "Make", "Model", "VIN", "Year" },
                values: new object[] { 3, "Blue", new DateTime(2022, 3, 23, 0, 0, 0, 0, DateTimeKind.Local), 555m, "For Employees", "Honda", "Masda", "QE-5426", "2020" });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "Id", "Color", "CreatedOn", "CurrentValue", "Description", "Make", "Model", "VIN", "Year" },
                values: new object[] { 4, "Blue", new DateTime(2022, 3, 23, 0, 0, 0, 0, DateTimeKind.Local), 555m, "For CEO", "Honda", "Masda", "W690001", "2020" });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "Id", "Color", "CreatedOn", "CurrentValue", "Description", "Make", "Model", "VIN", "Year" },
                values: new object[] { 5, "Blue", new DateTime(2022, 3, 23, 0, 0, 0, 0, DateTimeKind.Local), 555m, "For Transporting", "Honda", "Masda", "PA-59977", "2020" });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "Id", "Color", "CreatedOn", "CurrentValue", "Description", "Make", "Model", "VIN", "Year" },
                values: new object[] { 6, "Blue", new DateTime(2022, 3, 23, 0, 0, 0, 0, DateTimeKind.Local), 555m, "For Production 2", "Honda", "Masda", "DO1005", "2020" });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "Id", "Color", "CreatedOn", "CurrentValue", "Description", "Make", "Model", "VIN", "Year" },
                values: new object[] { 7, "Blue", new DateTime(2022, 3, 23, 0, 0, 0, 0, DateTimeKind.Local), 555m, "For Events", "Honda", "Masda", "AF97-23", "2020" });

            migrationBuilder.InsertData(
                table: "Maintenances",
                columns: new[] { "Id", "EstimatedCost", "MilesToExecuteTask", "TaskDetails", "Title", "ToolsNeeded" },
                values: new object[] { 1, 2500m, 5000, "Replace", "Change Tires", "ToolBox A357" });

            migrationBuilder.InsertData(
                table: "Maintenances",
                columns: new[] { "Id", "EstimatedCost", "MilesToExecuteTask", "TaskDetails", "Title", "ToolsNeeded" },
                values: new object[] { 2, 500m, 5000, "Replace", "Change Oil", "ToolBox Q977" });

            migrationBuilder.InsertData(
                table: "Maintenances",
                columns: new[] { "Id", "EstimatedCost", "MilesToExecuteTask", "TaskDetails", "Title", "ToolsNeeded" },
                values: new object[] { 3, 350m, 5000, "Review", "Check Engine", "ToolBox D-1002" });

            migrationBuilder.InsertData(
                table: "Schedule",
                columns: new[] { "Id", "AssetId", "MaintenanceId" },
                values: new object[] { 1, 1, 3 });

            migrationBuilder.InsertData(
                table: "Schedule",
                columns: new[] { "Id", "AssetId", "MaintenanceId" },
                values: new object[] { 2, 1, 2 });

            migrationBuilder.InsertData(
                table: "Schedule",
                columns: new[] { "Id", "AssetId", "MaintenanceId" },
                values: new object[] { 3, 1, 1 });

            migrationBuilder.InsertData(
                table: "Schedule",
                columns: new[] { "Id", "AssetId", "MaintenanceId" },
                values: new object[] { 4, 2, 3 });

            migrationBuilder.InsertData(
                table: "Schedule",
                columns: new[] { "Id", "AssetId", "MaintenanceId" },
                values: new object[] { 5, 3, 2 });

            migrationBuilder.InsertData(
                table: "Schedule",
                columns: new[] { "Id", "AssetId", "MaintenanceId" },
                values: new object[] { 6, 4, 1 });

            migrationBuilder.InsertData(
                table: "Schedule",
                columns: new[] { "Id", "AssetId", "MaintenanceId" },
                values: new object[] { 7, 5, 2 });

            migrationBuilder.InsertData(
                table: "Schedule",
                columns: new[] { "Id", "AssetId", "MaintenanceId" },
                values: new object[] { 8, 5, 3 });

            migrationBuilder.InsertData(
                table: "Schedule",
                columns: new[] { "Id", "AssetId", "MaintenanceId" },
                values: new object[] { 9, 6, 2 });

            migrationBuilder.InsertData(
                table: "Schedule",
                columns: new[] { "Id", "AssetId", "MaintenanceId" },
                values: new object[] { 10, 7, 3 });

            migrationBuilder.InsertData(
                table: "Schedule",
                columns: new[] { "Id", "AssetId", "MaintenanceId" },
                values: new object[] { 11, 7, 2 });

            migrationBuilder.InsertData(
                table: "Schedule",
                columns: new[] { "Id", "AssetId", "MaintenanceId" },
                values: new object[] { 12, 7, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Maintenances",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Maintenances",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Maintenances",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Schedule",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Schedule",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Schedule",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Schedule",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Schedule",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Schedule",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Schedule",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Schedule",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Schedule",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Schedule",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Schedule",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Schedule",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}

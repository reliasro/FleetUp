using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Soinsoft.FleetUp.Infra.Persistence.Migrations
{
    public partial class WorkOrderMaterial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Schedule_Assets_AssetId",
                table: "Schedule");

            migrationBuilder.DropIndex(
                name: "IX_Schedule_AssetId",
                table: "Schedule");

            migrationBuilder.CreateTable(
                name: "WorkOrderMaterial",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    WorkOrderId = table.Column<int>(type: "INTEGER", nullable: false),
                    ItemNo = table.Column<int>(type: "INTEGER", nullable: false),
                    Code = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false),
                    Cost = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkOrderMaterial", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkOrderMaterial_WorkOrders_WorkOrderId",
                        column: x => x.WorkOrderId,
                        principalTable: "WorkOrders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WorkOrderMaterial_WorkOrderId",
                table: "WorkOrderMaterial",
                column: "WorkOrderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WorkOrderMaterial");

            migrationBuilder.CreateIndex(
                name: "IX_Schedule_AssetId",
                table: "Schedule",
                column: "AssetId");

            migrationBuilder.AddForeignKey(
                name: "FK_Schedule_Assets_AssetId",
                table: "Schedule",
                column: "AssetId",
                principalTable: "Assets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

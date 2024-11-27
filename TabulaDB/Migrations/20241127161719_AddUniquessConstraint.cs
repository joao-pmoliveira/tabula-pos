using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TabulaDB.Migrations
{
    /// <inheritdoc />
    public partial class AddUniquessConstraint : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Receipts_ServiceStations_ServiceStationId",
                table: "Receipts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ServiceStations",
                table: "ServiceStations");

            migrationBuilder.RenameTable(
                name: "ServiceStations",
                newName: "service_stations");

            migrationBuilder.AddPrimaryKey(
                name: "PK_service_stations",
                table: "service_stations",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Username",
                table: "Users",
                column: "Username",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Roles_Name",
                table: "Roles",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_receipt_status_Name",
                table: "receipt_status",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_Name",
                table: "Products",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_product_categories_Name",
                table: "product_categories",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_service_stations_Name",
                table: "service_stations",
                column: "Name",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Receipts_service_stations_ServiceStationId",
                table: "Receipts",
                column: "ServiceStationId",
                principalTable: "service_stations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Receipts_service_stations_ServiceStationId",
                table: "Receipts");

            migrationBuilder.DropIndex(
                name: "IX_Users_Username",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Roles_Name",
                table: "Roles");

            migrationBuilder.DropIndex(
                name: "IX_receipt_status_Name",
                table: "receipt_status");

            migrationBuilder.DropIndex(
                name: "IX_Products_Name",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_product_categories_Name",
                table: "product_categories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_service_stations",
                table: "service_stations");

            migrationBuilder.DropIndex(
                name: "IX_service_stations_Name",
                table: "service_stations");

            migrationBuilder.RenameTable(
                name: "service_stations",
                newName: "ServiceStations");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ServiceStations",
                table: "ServiceStations",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Receipts_ServiceStations_ServiceStationId",
                table: "Receipts",
                column: "ServiceStationId",
                principalTable: "ServiceStations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace AsociatiaDeTarani.Migrations
{
    public partial class DataAddedMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Producers",
                columns: new[] { "ProducerId", "DeliveryCost", "MinimumOrder", "Name", "PhoneNumber" },
                values: new object[] { 1, 15.0, 200.0, "Ionescu Mihai", "0712345678" });

            migrationBuilder.InsertData(
                table: "Producers",
                columns: new[] { "ProducerId", "DeliveryCost", "MinimumOrder", "Name", "PhoneNumber" },
                values: new object[] { 2, 12.0, 150.0, "Petre Vasile", "0745678123" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "AvailableStock", "Name", "PhotoUrl", "Price", "ProducerId", "Weight" },
                values: new object[] { 1, 100.0, "Rosii Bio", "~/Images/IonescuMihai/RosiiBio.jpg", 6.0, 1, 1.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "AvailableStock", "Name", "PhotoUrl", "Price", "ProducerId", "Weight" },
                values: new object[] { 2, 80.0, "Castraveti Bio", "~/Images/IonescuMihai/CastravetiBio.jpg", 3.0, 1, 1.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "AvailableStock", "Name", "PhotoUrl", "Price", "ProducerId", "Weight" },
                values: new object[] { 3, 200.0, "Varza Bio", "~/Images/PetreVasile/VarzaBio.jpg", 50.0, 2, 10.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "ProducerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "ProducerId",
                keyValue: 2);
        }
    }
}

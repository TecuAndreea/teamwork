using Microsoft.EntityFrameworkCore.Migrations;

namespace AsociatiaDeTarani.Migrations
{
    public partial class ProducersAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Producers",
                columns: new[] { "ProducerId", "DeliveryCost", "MinimumOrder", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { 4, 13.0, 120.0, "Mihai Alexandru", "0712345622" },
                    { 5, 15.0, 100.0, "Costea Andrei", "0798754321" },
                    { 6, 17.0, 180.0, "Miron Claudiu", "0755533322" },
                    { 7, 19.0, 150.0, "Soare Anisoara", "0711223344" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "PhotoUrl",
                value: "/Images/IonescuMihai/RosiiBio.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "PhotoUrl",
                value: "/Images/IonescuMihai/CastravetiBio.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "PhotoUrl",
                value: "/Images/PetreVasile/VarzaBio.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "ProducerId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "ProducerId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "ProducerId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "ProducerId",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "PhotoUrl",
                value: "~/Images/IonescuMihai/RosiiBio.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "PhotoUrl",
                value: "~/Images/IonescuMihai/CastravetiBio.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "PhotoUrl",
                value: "~/Images/PetreVasile/VarzaBio.jpg");
        }
    }
}

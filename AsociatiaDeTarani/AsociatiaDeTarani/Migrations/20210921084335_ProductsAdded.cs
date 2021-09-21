using Microsoft.EntityFrameworkCore.Migrations;

namespace AsociatiaDeTarani.Migrations
{
    public partial class ProductsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "AvailableStock", "Name", "PhotoUrl", "Price", "ProducerId", "Weight" },
                values: new object[,]
                {
                    { 5, 200.0, "Morcovi Bio", "/Images/IonescuMihai/morcovi.jpg", 2.0, 1, 1.0 },
                    { 24, 700.0, "Ceapa", "/Images/CosteaAndrei/ceapa2", 75.0, 7, 30.0 },
                    { 23, 1200.0, "Cartofi", "/Images/CosteaAndrei/cartofi1", 75.0, 7, 75.0 },
                    { 22, 300.0, "Ridichi", "/Images/CosteaAndrei/ridichi", 25.0, 6, 3.0 },
                    { 21, 300.0, "Mere", "/Images/CosteaAndrei/mere1", 20.0, 6, 5.0 },
                    { 20, 400.0, "ceapaRosie1", "/Images/CosteaAndrei/ceapaRosie1", 30.0, 6, 10.0 },
                    { 19, 300.0, "Castraveti", "/Images/CosteaAndrei/castraveti", 40.0, 6, 10.0 },
                    { 18, 300.0, "Ceapa Rosie", "/Images/CosteaAndrei/ceapaRosie", 60.0, 5, 25.0 },
                    { 17, 600.0, "Ceapa", "/Images/CosteaAndrei/ceapa", 45.0, 5, 20.0 },
                    { 16, 1000.0, "Cartofi", "/Images/CosteaAndrei/cartofi2", 25.0, 5, 25.0 },
                    { 15, 500.0, "Cartofi Rosii", "/Images/CosteaAndrei/cartofiRosii", 50.0, 5, 25.0 },
                    { 14, 175.0, "Morcovi Bio", "/Images/MihaiAlexandru/morcovi1", 30.0, 4, 10.0 },
                    { 13, 300.0, "Ridichi Bio", "/Images/MihaiAlexandru/ridichi1", 100.0, 4, 10.0 },
                    { 12, 60.0, "Castraveti Bio", "/Images/MihaiAlexandru/salata2", 10.0, 4, 2.0 },
                    { 11, 200.0, "Castraveti Bio", "/Images/MihaiAlexandru/castravetiBio", 35.0, 4, 10.0 },
                    { 10, 200.0, "Ceapa", "/Images/PetreVasile/ceapa1.jpg", 50.0, 4, 25.0 },
                    { 9, 1500.0, "Cartofi", "/Images/PetreVasile/cartofi.jpg", 50.0, 2, 50.0 },
                    { 8, 200.0, "Ceapa", "/Images/PetreVasile/ceapa1.jpg", 50.0, 2, 25.0 },
                    { 7, 100.0, "Salata", "/Images/PetreVasile/salata1.jpg", 5.0, 2, 1.0 },
                    { 6, 70.0, "Ridichi Bio", "/Images/IonescuMihai/ridichi.jpg", 10.0, 1, 1.0 },
                    { 25, 200.0, "Mere", "/Images/CosteaAndrei/mere2", 20.0, 7, 5.0 },
                    { 26, 200.0, "Morcovi", "/Images/CosteaAndrei/morcovi2", 15.0, 7, 10.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 26);
        }
    }
}

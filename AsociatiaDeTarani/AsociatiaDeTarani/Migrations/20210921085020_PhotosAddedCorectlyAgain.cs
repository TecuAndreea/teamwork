using Microsoft.EntityFrameworkCore.Migrations;

namespace AsociatiaDeTarani.Migrations
{
    public partial class PhotosAddedCorectlyAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                column: "PhotoUrl",
                value: "/Images/MihaiAlexandru/castravetiBio.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                column: "PhotoUrl",
                value: "/Images/MihaiAlexandru/salata2.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                column: "PhotoUrl",
                value: "/Images/MihaiAlexandru/ridichi1.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                column: "PhotoUrl",
                value: "/Images/MihaiAlexandru/morcovi1.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15,
                column: "PhotoUrl",
                value: "/Images/CosteaAndrei/cartofiRosii.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16,
                column: "PhotoUrl",
                value: "/Images/CosteaAndrei/cartofi2.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17,
                column: "PhotoUrl",
                value: "/Images/CosteaAndrei/ceapa.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18,
                column: "PhotoUrl",
                value: "/Images/CosteaAndrei/ceapaRosie.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19,
                column: "PhotoUrl",
                value: "/Images/MironClaudiu/castraveti.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20,
                column: "PhotoUrl",
                value: "/Images/MironClaudiu/ceapaRosie1.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 21,
                column: "PhotoUrl",
                value: "/Images/MironClaudiu/mere1.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 22,
                column: "PhotoUrl",
                value: "/Images/MironClaudiu/ridichi.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 23,
                column: "PhotoUrl",
                value: "/Images/SoareAnisoara/cartofi1.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 24,
                column: "PhotoUrl",
                value: "/Images/SoareAnisoara/ceapa2.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 25,
                column: "PhotoUrl",
                value: "/Images/SoareAnisoara/mere2.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 26,
                column: "PhotoUrl",
                value: "/Images/SoareAnisoara/morcovi2.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                column: "PhotoUrl",
                value: "/Images/MihaiAlexandru/castravetiBio");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                column: "PhotoUrl",
                value: "/Images/MihaiAlexandru/salata2");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                column: "PhotoUrl",
                value: "/Images/MihaiAlexandru/ridichi1");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                column: "PhotoUrl",
                value: "/Images/MihaiAlexandru/morcovi1");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15,
                column: "PhotoUrl",
                value: "/Images/CosteaAndrei/cartofiRosii");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16,
                column: "PhotoUrl",
                value: "/Images/CosteaAndrei/cartofi2");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17,
                column: "PhotoUrl",
                value: "/Images/CosteaAndrei/ceapa");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18,
                column: "PhotoUrl",
                value: "/Images/CosteaAndrei/ceapaRosie");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19,
                column: "PhotoUrl",
                value: "/Images/MironClaudiu/castraveti");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20,
                column: "PhotoUrl",
                value: "/Images/MironClaudiu/ceapaRosie1");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 21,
                column: "PhotoUrl",
                value: "/Images/MironClaudiu/mere1");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 22,
                column: "PhotoUrl",
                value: "/Images/MironClaudiu/ridichi");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 23,
                column: "PhotoUrl",
                value: "/Images/SoareAnisoara/cartofi1");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 24,
                column: "PhotoUrl",
                value: "/Images/SoareAnisoara/ceapa2");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 25,
                column: "PhotoUrl",
                value: "/Images/SoareAnisoara/mere2.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 26,
                column: "PhotoUrl",
                value: "/Images/SoareAnisoara/morcovi2.jpg");
        }
    }
}

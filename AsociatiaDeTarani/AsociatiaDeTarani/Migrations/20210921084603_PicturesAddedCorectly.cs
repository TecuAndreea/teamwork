using Microsoft.EntityFrameworkCore.Migrations;

namespace AsociatiaDeTarani.Migrations
{
    public partial class PicturesAddedCorectly : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                value: "/Images/SoareAnisoara/mere2");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 26,
                column: "PhotoUrl",
                value: "/Images/SoareAnisoara/morcovi2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19,
                column: "PhotoUrl",
                value: "/Images/CosteaAndrei/castraveti");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20,
                column: "PhotoUrl",
                value: "/Images/CosteaAndrei/ceapaRosie1");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 21,
                column: "PhotoUrl",
                value: "/Images/CosteaAndrei/mere1");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 22,
                column: "PhotoUrl",
                value: "/Images/CosteaAndrei/ridichi");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 23,
                column: "PhotoUrl",
                value: "/Images/CosteaAndrei/cartofi1");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 24,
                column: "PhotoUrl",
                value: "/Images/CosteaAndrei/ceapa2");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 25,
                column: "PhotoUrl",
                value: "/Images/CosteaAndrei/mere2");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 26,
                column: "PhotoUrl",
                value: "/Images/CosteaAndrei/morcovi2");
        }
    }
}

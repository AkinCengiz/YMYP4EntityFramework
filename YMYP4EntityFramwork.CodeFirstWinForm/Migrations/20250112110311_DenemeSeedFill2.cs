using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YMYP4EntityFramwork.CodeFirstWinForm.Migrations
{
    /// <inheritdoc />
    public partial class DenemeSeedFill2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Denemes",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Description - 1", "Name - 1" },
                    { 2, "Description - 2", "Name - 2" },
                    { 3, "Description - 3", "Name - 3" },
                    { 4, "Description - 4", "Name - 4" },
                    { 5, "Description - 5", "Name - 5" },
                    { 6, "Description - 6", "Name - 6" },
                    { 7, "Description - 7", "Name - 7" },
                    { 8, "Description - 8", "Name - 8" },
                    { 9, "Description - 9", "Name - 9" },
                    { 10, "Description - 10", "Name - 10" },
                    { 11, "Description - 11", "Name - 11" },
                    { 12, "Description - 12", "Name - 12" },
                    { 13, "Description - 13", "Name - 13" },
                    { 14, "Description - 14", "Name - 14" },
                    { 15, "Description - 15", "Name - 15" },
                    { 16, "Description - 16", "Name - 16" },
                    { 17, "Description - 17", "Name - 17" },
                    { 18, "Description - 18", "Name - 18" },
                    { 19, "Description - 19", "Name - 19" },
                    { 20, "Description - 20", "Name - 20" },
                    { 21, "Description - 21", "Name - 21" },
                    { 22, "Description - 22", "Name - 22" },
                    { 23, "Description - 23", "Name - 23" },
                    { 24, "Description - 24", "Name - 24" },
                    { 25, "Description - 25", "Name - 25" },
                    { 26, "Description - 26", "Name - 26" },
                    { 27, "Description - 27", "Name - 27" },
                    { 28, "Description - 28", "Name - 28" },
                    { 29, "Description - 29", "Name - 29" },
                    { 30, "Description - 30", "Name - 30" },
                    { 31, "Description - 31", "Name - 31" },
                    { 32, "Description - 32", "Name - 32" },
                    { 33, "Description - 33", "Name - 33" },
                    { 34, "Description - 34", "Name - 34" },
                    { 35, "Description - 35", "Name - 35" },
                    { 36, "Description - 36", "Name - 36" },
                    { 37, "Description - 37", "Name - 37" },
                    { 38, "Description - 38", "Name - 38" },
                    { 39, "Description - 39", "Name - 39" },
                    { 40, "Description - 40", "Name - 40" },
                    { 41, "Description - 41", "Name - 41" },
                    { 42, "Description - 42", "Name - 42" },
                    { 43, "Description - 43", "Name - 43" },
                    { 44, "Description - 44", "Name - 44" },
                    { 45, "Description - 45", "Name - 45" },
                    { 46, "Description - 46", "Name - 46" },
                    { 47, "Description - 47", "Name - 47" },
                    { 48, "Description - 48", "Name - 48" },
                    { 49, "Description - 49", "Name - 49" },
                    { 50, "Description - 50", "Name - 50" },
                    { 51, "Description - 51", "Name - 51" },
                    { 52, "Description - 52", "Name - 52" },
                    { 53, "Description - 53", "Name - 53" },
                    { 54, "Description - 54", "Name - 54" },
                    { 55, "Description - 55", "Name - 55" },
                    { 56, "Description - 56", "Name - 56" },
                    { 57, "Description - 57", "Name - 57" },
                    { 58, "Description - 58", "Name - 58" },
                    { 59, "Description - 59", "Name - 59" },
                    { 60, "Description - 60", "Name - 60" },
                    { 61, "Description - 61", "Name - 61" },
                    { 62, "Description - 62", "Name - 62" },
                    { 63, "Description - 63", "Name - 63" },
                    { 64, "Description - 64", "Name - 64" },
                    { 65, "Description - 65", "Name - 65" },
                    { 66, "Description - 66", "Name - 66" },
                    { 67, "Description - 67", "Name - 67" },
                    { 68, "Description - 68", "Name - 68" },
                    { 69, "Description - 69", "Name - 69" },
                    { 70, "Description - 70", "Name - 70" },
                    { 71, "Description - 71", "Name - 71" },
                    { 72, "Description - 72", "Name - 72" },
                    { 73, "Description - 73", "Name - 73" },
                    { 74, "Description - 74", "Name - 74" },
                    { 75, "Description - 75", "Name - 75" },
                    { 76, "Description - 76", "Name - 76" },
                    { 77, "Description - 77", "Name - 77" },
                    { 78, "Description - 78", "Name - 78" },
                    { 79, "Description - 79", "Name - 79" },
                    { 80, "Description - 80", "Name - 80" },
                    { 81, "Description - 81", "Name - 81" },
                    { 82, "Description - 82", "Name - 82" },
                    { 83, "Description - 83", "Name - 83" },
                    { 84, "Description - 84", "Name - 84" },
                    { 85, "Description - 85", "Name - 85" },
                    { 86, "Description - 86", "Name - 86" },
                    { 87, "Description - 87", "Name - 87" },
                    { 88, "Description - 88", "Name - 88" },
                    { 89, "Description - 89", "Name - 89" },
                    { 90, "Description - 90", "Name - 90" },
                    { 91, "Description - 91", "Name - 91" },
                    { 92, "Description - 92", "Name - 92" },
                    { 93, "Description - 93", "Name - 93" },
                    { 94, "Description - 94", "Name - 94" },
                    { 95, "Description - 95", "Name - 95" },
                    { 96, "Description - 96", "Name - 96" },
                    { 97, "Description - 97", "Name - 97" },
                    { 98, "Description - 98", "Name - 98" },
                    { 99, "Description - 99", "Name - 99" },
                    { 100, "Description - 100", "Name - 100" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Denemes",
                keyColumn: "Id",
                keyValue: 100);
        }
    }
}

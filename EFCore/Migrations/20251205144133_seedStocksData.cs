using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFCore.Migrations
{
    /// <inheritdoc />
    public partial class seedStocksData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Stocks",
                columns: new[] { "Id", "Balance", "Industry", "Name", "Sector", "Symbol" },
                values: new object[,]
                {
                    { 1, 1967.0799999999999, "n/a", "First Trust Total US Market AlphaDEX ETF", "n/a", "TUSA" },
                    { 2, 99345.820000000007, "Biotechnology: Biological Products (No Diagnostic Substances)", "aTyr Pharma, Inc.", "Health Care", "LIFE" },
                    { 3, 99794.809999999998, "Major Banks", "1st Source Corporation", "Finance", "SRCE" },
                    { 4, 72500.850000000006, "Major Pharmaceuticals", "BioDelivery Sciences International, Inc.", "Health Care", "BDSI" },
                    { 5, 23123.77, "Major Pharmaceuticals", "Summit Therapeutics plc", "Health Care", "SMMT" },
                    { 6, 95595.259999999995, "Computer Software: Prepackaged Software", "CYREN Ltd.", "Technology", "CYRN" },
                    { 7, 54470.32, "Agricultural Chemicals", "Evogene Ltd.", "Basic Industries", "EVGN" },
                    { 8, 44935.809999999998, "Precious Metals", "Rio Tinto Plc", "Basic Industries", "RIO" },
                    { 9, 98873.449999999997, "Containers/Packaging", "Avery Dennison Corporation", "Consumer Durables", "AVY" },
                    { 10, 51308.290000000001, "Real Estate", "Optibase Ltd.", "Finance", "OBAS" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}

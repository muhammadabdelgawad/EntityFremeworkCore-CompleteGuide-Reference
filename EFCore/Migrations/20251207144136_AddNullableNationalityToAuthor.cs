using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore.Migrations
{
    /// <inheritdoc />
    public partial class AddNullableNationalityToAuthor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NationalityId",
                table: "Authors",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Authors_NationalityId",
                table: "Authors",
                column: "NationalityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Authors_Nationalities_NationalityId",
                table: "Authors",
                column: "NationalityId",
                principalTable: "Nationalities",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Authors_Nationalities_NationalityId",
                table: "Authors");

            migrationBuilder.DropIndex(
                name: "IX_Authors_NationalityId",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "NationalityId",
                table: "Authors");
        }
    }
}

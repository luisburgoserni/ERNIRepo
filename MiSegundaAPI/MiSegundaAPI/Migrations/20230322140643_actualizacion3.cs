using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MiSegundaAPI.Migrations
{
    /// <inheritdoc />
    public partial class actualizacion3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Person_House_HouseId",
                table: "Person");

            migrationBuilder.AlterColumn<int>(
                name: "HouseId",
                table: "Person",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Person_House_HouseId",
                table: "Person",
                column: "HouseId",
                principalTable: "House",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Person_House_HouseId",
                table: "Person");

            migrationBuilder.AlterColumn<int>(
                name: "HouseId",
                table: "Person",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Person_House_HouseId",
                table: "Person",
                column: "HouseId",
                principalTable: "House",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

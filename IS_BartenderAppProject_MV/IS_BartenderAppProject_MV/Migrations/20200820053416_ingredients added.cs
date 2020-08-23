using Microsoft.EntityFrameworkCore.Migrations;

namespace IS_BartenderAppProject_MV.Migrations
{
    public partial class ingredientsadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "DrinkCost",
                table: "Drinks",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "DrinkCost",
                table: "Drinks",
                type: "int",
                nullable: false,
                oldClrType: typeof(double));
        }
    }
}

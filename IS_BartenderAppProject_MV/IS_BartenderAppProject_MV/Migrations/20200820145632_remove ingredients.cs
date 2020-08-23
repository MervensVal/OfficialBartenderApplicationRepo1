using Microsoft.EntityFrameworkCore.Migrations;

namespace IS_BartenderAppProject_MV.Migrations
{
    public partial class removeingredients : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ingredients",
                table: "Drinks");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Ingredients",
                table: "Drinks",
                type: "nvarchar(200)",
                nullable: true);
        }
    }
}

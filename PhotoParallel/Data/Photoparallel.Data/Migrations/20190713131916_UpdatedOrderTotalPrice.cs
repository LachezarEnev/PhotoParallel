using Microsoft.EntityFrameworkCore.Migrations;

namespace Photoparallel.Data.Migrations
{
    public partial class UpdatedOrderTotalPrice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "TotalPrice",
                table: "Orders",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalPrice",
                table: "Orders");
        }
    }
}

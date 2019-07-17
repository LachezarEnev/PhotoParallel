using Microsoft.EntityFrameworkCore.Migrations;

namespace Photoparallel.Data.Migrations
{
    public partial class AddedInPendingOrdersProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InPendingOrders",
                table: "Products",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InPendingOrders",
                table: "Products");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace Photoparallel.Data.Migrations
{
    public partial class UpdatedOrderEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "paymentType",
                table: "Orders",
                newName: "PaymentType");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PaymentType",
                table: "Orders",
                newName: "paymentType");
        }
    }
}

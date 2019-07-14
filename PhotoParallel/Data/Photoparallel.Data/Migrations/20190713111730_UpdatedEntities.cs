using Microsoft.EntityFrameworkCore.Migrations;

namespace Photoparallel.Data.Migrations
{
    public partial class UpdatedEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PaymentStatus",
                table: "Orders",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Number",
                table: "CreditCards",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Cvc2",
                table: "CreditCards",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ExpirationDate",
                table: "CreditCards",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PaymentStatus",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Cvc2",
                table: "CreditCards");

            migrationBuilder.DropColumn(
                name: "ExpirationDate",
                table: "CreditCards");

            migrationBuilder.AlterColumn<string>(
                name: "Number",
                table: "CreditCards",
                nullable: true,
                oldClrType: typeof(int));
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace Photoparallel.Data.Migrations
{
    public partial class AddedCreditMonthsAndTotalAmount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Guarantee",
                table: "Rents",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "Months",
                table: "CreditContracts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalAmount",
                table: "CreditContracts",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Guarantee",
                table: "Rents");

            migrationBuilder.DropColumn(
                name: "Months",
                table: "CreditContracts");

            migrationBuilder.DropColumn(
                name: "TotalAmount",
                table: "CreditContracts");
        }
    }
}

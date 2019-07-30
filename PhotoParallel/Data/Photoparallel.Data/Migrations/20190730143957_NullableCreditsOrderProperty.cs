using Microsoft.EntityFrameworkCore.Migrations;

namespace Photoparallel.Data.Migrations
{
    public partial class NullableCreditsOrderProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_CreditContracts_OrderId",
                table: "CreditContracts");

            migrationBuilder.AlterColumn<int>(
                name: "OrderId",
                table: "CreditContracts",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "CreditCompanies",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VatNumber",
                table: "CreditCompanies",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CreditContracts_OrderId",
                table: "CreditContracts",
                column: "OrderId",
                unique: true,
                filter: "[OrderId] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_CreditContracts_OrderId",
                table: "CreditContracts");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "CreditCompanies");

            migrationBuilder.DropColumn(
                name: "VatNumber",
                table: "CreditCompanies");

            migrationBuilder.AlterColumn<int>(
                name: "OrderId",
                table: "CreditContracts",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CreditContracts_OrderId",
                table: "CreditContracts",
                column: "OrderId",
                unique: true);
        }
    }
}

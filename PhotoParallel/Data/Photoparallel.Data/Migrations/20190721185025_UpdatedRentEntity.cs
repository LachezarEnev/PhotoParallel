using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Photoparallel.Data.Migrations
{
    public partial class UpdatedRentEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReturnedOn",
                table: "Rents");

            migrationBuilder.RenameColumn(
                name: "RentedOn",
                table: "Rents",
                newName: "ReturnDate");

            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "Rents",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Penalty",
                table: "Rents",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Recipient",
                table: "Rents",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RecipientPhoneNumber",
                table: "Rents",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "RentDate",
                table: "Rents",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "RentStatus",
                table: "Rents",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ReturnedOnTime",
                table: "Rents",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Shipping",
                table: "Rents",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comment",
                table: "Rents");

            migrationBuilder.DropColumn(
                name: "Penalty",
                table: "Rents");

            migrationBuilder.DropColumn(
                name: "Recipient",
                table: "Rents");

            migrationBuilder.DropColumn(
                name: "RecipientPhoneNumber",
                table: "Rents");

            migrationBuilder.DropColumn(
                name: "RentDate",
                table: "Rents");

            migrationBuilder.DropColumn(
                name: "RentStatus",
                table: "Rents");

            migrationBuilder.DropColumn(
                name: "ReturnedOnTime",
                table: "Rents");

            migrationBuilder.DropColumn(
                name: "Shipping",
                table: "Rents");

            migrationBuilder.RenameColumn(
                name: "ReturnDate",
                table: "Rents",
                newName: "RentedOn");

            migrationBuilder.AddColumn<DateTime>(
                name: "ReturnedOn",
                table: "Rents",
                nullable: true);
        }
    }
}

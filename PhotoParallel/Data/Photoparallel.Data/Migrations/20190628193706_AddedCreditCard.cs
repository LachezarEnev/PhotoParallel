using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Photoparallel.Data.Migrations
{
    public partial class AddedCreditCard : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreditCardId",
                table: "Rents",
                nullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "Photo",
                table: "Products",
                nullable: true,
                oldClrType: typeof(byte));

            migrationBuilder.AddColumn<string>(
                name: "CreditCardId",
                table: "Orders",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "CreditContracts",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreditStatus",
                table: "CreditContracts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "IdNumber",
                table: "CreditContracts",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Salary",
                table: "CreditContracts",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Ucn",
                table: "CreditContracts",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CrediCards",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Number = table.Column<string>(nullable: true),
                    CustomerId = table.Column<string>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CrediCards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CrediCards_AspNetUsers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Rents_CreditCardId",
                table: "Rents",
                column: "CreditCardId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CreditCardId",
                table: "Orders",
                column: "CreditCardId");

            migrationBuilder.CreateIndex(
                name: "IX_CrediCards_CustomerId",
                table: "CrediCards",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_CrediCards_CreditCardId",
                table: "Orders",
                column: "CreditCardId",
                principalTable: "CrediCards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rents_CrediCards_CreditCardId",
                table: "Rents",
                column: "CreditCardId",
                principalTable: "CrediCards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_CrediCards_CreditCardId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Rents_CrediCards_CreditCardId",
                table: "Rents");

            migrationBuilder.DropTable(
                name: "CrediCards");

            migrationBuilder.DropIndex(
                name: "IX_Rents_CreditCardId",
                table: "Rents");

            migrationBuilder.DropIndex(
                name: "IX_Orders_CreditCardId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "CreditCardId",
                table: "Rents");

            migrationBuilder.DropColumn(
                name: "CreditCardId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "CreditContracts");

            migrationBuilder.DropColumn(
                name: "CreditStatus",
                table: "CreditContracts");

            migrationBuilder.DropColumn(
                name: "IdNumber",
                table: "CreditContracts");

            migrationBuilder.DropColumn(
                name: "Salary",
                table: "CreditContracts");

            migrationBuilder.DropColumn(
                name: "Ucn",
                table: "CreditContracts");

            migrationBuilder.AlterColumn<byte>(
                name: "Photo",
                table: "Products",
                nullable: false,
                oldClrType: typeof(byte[]),
                oldNullable: true);
        }
    }
}

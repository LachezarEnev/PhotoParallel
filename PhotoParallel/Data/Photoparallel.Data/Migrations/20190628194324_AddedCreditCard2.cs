using Microsoft.EntityFrameworkCore.Migrations;

namespace Photoparallel.Data.Migrations
{
    public partial class AddedCreditCard2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_CrediCards_CreditCardId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Rents_CrediCards_CreditCardId",
                table: "Rents");

            migrationBuilder.DropTable(
                name: "CrediCards");

            migrationBuilder.CreateTable(
                name: "CreditCards",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Number = table.Column<string>(nullable: true),
                    CustomerId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreditCards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CreditCards_AspNetUsers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CreditCards_CustomerId",
                table: "CreditCards",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_CreditCards_CreditCardId",
                table: "Orders",
                column: "CreditCardId",
                principalTable: "CreditCards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rents_CreditCards_CreditCardId",
                table: "Rents",
                column: "CreditCardId",
                principalTable: "CreditCards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_CreditCards_CreditCardId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Rents_CreditCards_CreditCardId",
                table: "Rents");

            migrationBuilder.DropTable(
                name: "CreditCards");

            migrationBuilder.CreateTable(
                name: "CrediCards",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CustomerId = table.Column<string>(nullable: true),
                    Number = table.Column<string>(nullable: true)
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
    }
}

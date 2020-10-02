using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace src.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    customerId = table.Column<Guid>(nullable: false),
                    CreateAt = table.Column<DateTime>(nullable: false),
                    address = table.Column<string>(maxLength: 100, nullable: true),
                    customerName = table.Column<string>(maxLength: 100, nullable: false),
                    customerType = table.Column<int>(nullable: false),
                    description = table.Column<string>(maxLength: 200, nullable: true),
                    email = table.Column<string>(maxLength: 100, nullable: true),
                    linkedin = table.Column<string>(maxLength: 100, nullable: true),
                    phone = table.Column<string>(maxLength: 20, nullable: true),
                    thumbUrl = table.Column<string>(maxLength: 255, nullable: true),
                    website = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.customerId);
                });

            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    contactId = table.Column<Guid>(nullable: false),
                    CreateAt = table.Column<DateTime>(nullable: false),
                    contactName = table.Column<string>(maxLength: 100, nullable: false),
                    customerId = table.Column<Guid>(nullable: false),
                    description = table.Column<string>(maxLength: 200, nullable: true),
                    email = table.Column<string>(maxLength: 100, nullable: false),
                    linkedin = table.Column<string>(maxLength: 100, nullable: true),
                    phone = table.Column<string>(maxLength: 20, nullable: true),
                    secondaryEmail = table.Column<string>(maxLength: 100, nullable: true),
                    thumbUrl = table.Column<string>(maxLength: 255, nullable: true),
                    website = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.contactId);
                    table.ForeignKey(
                        name: "FK_Contact_Customer_customerId",
                        column: x => x.customerId,
                        principalTable: "Customer",
                        principalColumn: "customerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contact_customerId",
                table: "Contact",
                column: "customerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.DropTable(
                name: "Customer");
        }
    }
}

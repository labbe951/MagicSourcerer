using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFcoreRelationships.Migrations
{
    /// <inheritdoc />
    public partial class Addednewentitysbandandbandmembers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "BandMemberId",
                table: "Users",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "BandMember",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BandMember", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_BandMemberId",
                table: "Users",
                column: "BandMemberId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_BandMember_BandMemberId",
                table: "Users",
                column: "BandMemberId",
                principalTable: "BandMember",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_BandMember_BandMemberId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "BandMember");

            migrationBuilder.DropIndex(
                name: "IX_Users_BandMemberId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "BandMemberId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Users");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Forceget.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CityId",
                table: "Offers",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Offers_CityId",
                table: "Offers",
                column: "CityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Offers_Cities_CityId",
                table: "Offers",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Offers_Cities_CityId",
                table: "Offers");

            migrationBuilder.DropIndex(
                name: "IX_Offers_CityId",
                table: "Offers");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "Offers");
        }
    }
}

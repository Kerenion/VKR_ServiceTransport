using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VKR_ServiceTransport.Ef.Migrations
{
    public partial class qwer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PathToPhoto",
                table: "Transports");

            migrationBuilder.AddColumn<DateOnly>(
                name: "DateNotify",
                table: "Notices",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateNotify",
                table: "Notices");

            migrationBuilder.AddColumn<string>(
                name: "PathToPhoto",
                table: "Transports",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}

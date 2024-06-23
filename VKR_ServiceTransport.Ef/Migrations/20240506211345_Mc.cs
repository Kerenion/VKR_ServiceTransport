using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VKR_ServiceTransport.Ef.Migrations
{
    public partial class Mc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SparePartsIntervals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    IntervalByDate = table.Column<string>(type: "TEXT", nullable: true),
                    IntervalByMileage = table.Column<string>(type: "TEXT", nullable: true),
                    TransportId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SparePartsIntervals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SparePartsIntervals_Transports_TransportId",
                        column: x => x.TransportId,
                        principalTable: "Transports",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_SparePartsIntervals_TransportId",
                table: "SparePartsIntervals",
                column: "TransportId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SparePartsIntervals");
        }
    }
}

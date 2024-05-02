using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdressBook.Migrations
{
    /// <inheritdoc />
    public partial class addReport : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Report",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Changes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Time = table.Column<TimeOnly>(type: "time", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsersId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PrimaryKey_ReportId", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Report_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Report_UsersId",
                table: "Report",
                column: "UsersId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Report");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class Test4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DbResult",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    EE3305 = table.Column<string>(type: "TEXT", nullable: false),
                    EE3302 = table.Column<string>(type: "TEXT", nullable: false),
                    EE3301 = table.Column<string>(type: "TEXT", nullable: false),
                    IS3307 = table.Column<string>(type: "TEXT", nullable: false),
                    EE3250 = table.Column<string>(type: "TEXT", nullable: false),
                    IS3302 = table.Column<string>(type: "TEXT", nullable: false),
                    EE3203 = table.Column<string>(type: "TEXT", nullable: false),
                    EE3251 = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DbResult", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DbResult");
        }
    }
}

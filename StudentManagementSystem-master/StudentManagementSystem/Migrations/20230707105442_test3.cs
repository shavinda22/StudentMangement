using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class test3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "DbStudents",
                newName: "PhoneNumbeR");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "DbStudents",
                newName: "LastNamE");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "DbStudents",
                newName: "FirstNamE");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "DbStudents",
                newName: "EmaiL");

            migrationBuilder.RenameColumn(
                name: "Adress",
                table: "DbStudents",
                newName: "AdresS");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PhoneNumbeR",
                table: "DbStudents",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "LastNamE",
                table: "DbStudents",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "FirstNamE",
                table: "DbStudents",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "EmaiL",
                table: "DbStudents",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "AdresS",
                table: "DbStudents",
                newName: "Adress");
        }
    }
}

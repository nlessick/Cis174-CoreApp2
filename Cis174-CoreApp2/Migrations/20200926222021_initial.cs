using Microsoft.EntityFrameworkCore.Migrations;

namespace Cis174_CoreApp2.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Grade = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentID);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentID", "FirstName", "Grade", "LastName" },
                values: new object[] { 1, "Nate", "B", "Essick" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentID", "FirstName", "Grade", "LastName" },
                values: new object[] { 2, "Hawkeye", "A", "Herkey" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentID", "FirstName", "Grade", "LastName" },
                values: new object[] { 3, "Indianapolis", "B", "Colts" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OfficeSeatBookingDAL.Migrations
{
    /// <inheritdoc />
    public partial class oop : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_Employee",
                columns: table => new
                {
                    EmpId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmpEmail = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    EmpPassword = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    EmpPhone = table.Column<double>(type: "float", nullable: false),
                    EmpGender = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    EmpSecretKey = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmpPlace = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmpRole = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmpDesignation = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Employee", x => x.EmpId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_Employee");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VuThiHuyen306.Migrations
{
    /// <inheritdoc />
    public partial class CreateTableVTH0306 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VTH0306",
                columns: table => new
                {
                    VTHId = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    VTHName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    VTHGender = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VTH0306", x => x.VTHId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VTH0306");
        }
    }
}

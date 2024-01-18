using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MedicalScan.DATABASE.Migrations
{
    /// <inheritdoc />
    public partial class R1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SpecialtyTB",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecialtyTB", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DoctorTB",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpecialtyID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorTB", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DoctorTB_SpecialtyTB_SpecialtyID",
                        column: x => x.SpecialtyID,
                        principalTable: "SpecialtyTB",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_DoctorTB_SpecialtyID",
                table: "DoctorTB",
                column: "SpecialtyID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DoctorTB");

            migrationBuilder.DropTable(
                name: "SpecialtyTB");
        }
    }
}

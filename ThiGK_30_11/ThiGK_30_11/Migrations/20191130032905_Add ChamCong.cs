using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ThiGK_30_11.Migrations
{
    public partial class AddChamCong : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChamCongs",
                columns: table => new
                {
                    MaCC = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nvarchar100 = table.Column<string>(name: "nvarchar(100)", nullable: true),
                    Thang = table.Column<int>(nullable: false),
                    Nam = table.Column<int>(nullable: false),
                    SoNgayLamTrongThang = table.Column<int>(nullable: false),
                    TongLuong = table.Column<float>(nullable: false),
                    MaPB = table.Column<int>(nullable: true),
                    MaNV = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChamCongs", x => x.MaCC);
                    table.ForeignKey(
                        name: "FK_ChamCongs_NhanViens_MaNV",
                        column: x => x.MaNV,
                        principalTable: "NhanViens",
                        principalColumn: "MaNV",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChamCongs_PhongBans_MaPB",
                        column: x => x.MaPB,
                        principalTable: "PhongBans",
                        principalColumn: "MaPB",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChamCongs_MaNV",
                table: "ChamCongs",
                column: "MaNV");

            migrationBuilder.CreateIndex(
                name: "IX_ChamCongs_MaPB",
                table: "ChamCongs",
                column: "MaPB");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChamCongs");
        }
    }
}

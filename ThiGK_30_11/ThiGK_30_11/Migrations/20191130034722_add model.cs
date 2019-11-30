using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ThiGK_30_11.Migrations
{
    public partial class addmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DiemDanh",
                columns: table => new
                {
                    MaDD = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Thang = table.Column<int>(nullable: false),
                    Tuan = table.Column<int>(nullable: false),
                    TenNV = table.Column<string>(nullable: true),
                    T2 = table.Column<bool>(nullable: false),
                    T3 = table.Column<bool>(nullable: false),
                    T4 = table.Column<bool>(nullable: false),
                    T5 = table.Column<bool>(nullable: false),
                    T6 = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiemDanh", x => x.MaDD);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DiemDanh");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace TimerStore.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    ProductImg = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Favourite = table.Column<bool>(nullable: false),
                    Gender = table.Column<string>(nullable: true),
                    MechanismType = table.Column<string>(nullable: true),
                    CaseMaterial = table.Column<string>(nullable: true),
                    wristletType = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(type: "decimal(8, 2)", nullable: false),
                    Discount = table.Column<double>(nullable: false),
                    Category = table.Column<string>(nullable: true),
                    BrandName = table.Column<string>(nullable: true),
                    totalCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}

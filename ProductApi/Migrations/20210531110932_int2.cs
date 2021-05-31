using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductApi.Migrations
{
    public partial class int2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_products_productTypes_ProductTypeId",
                table: "products");

            migrationBuilder.DropTable(
                name: "productTypes");

            migrationBuilder.DropIndex(
                name: "IX_products_ProductTypeId",
                table: "products");

            migrationBuilder.DropColumn(
                name: "ProductTypeId",
                table: "products");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductTypeId",
                table: "products",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "productTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productTypes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_products_ProductTypeId",
                table: "products",
                column: "ProductTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_products_productTypes_ProductTypeId",
                table: "products",
                column: "ProductTypeId",
                principalTable: "productTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

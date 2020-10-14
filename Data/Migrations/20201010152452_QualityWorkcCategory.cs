using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class QualityWorkcCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QualityWorks_Categories_CategoryId",
                table: "QualityWorks");

            migrationBuilder.DropIndex(
                name: "IX_QualityWorks_CategoryId",
                table: "QualityWorks");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "QualityWorks");

            migrationBuilder.AlterColumn<string>(
                name: "Details",
                table: "Services",
                maxLength: 350,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Text",
                table: "News",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.CreateTable(
                name: "QualityWorkCategory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QualityWorkId = table.Column<int>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QualityWorkCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QualityWorkCategory_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_QualityWorkCategory_QualityWorks_QualityWorkId",
                        column: x => x.QualityWorkId,
                        principalTable: "QualityWorks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_QualityWorkCategory_CategoryId",
                table: "QualityWorkCategory",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_QualityWorkCategory_QualityWorkId",
                table: "QualityWorkCategory",
                column: "QualityWorkId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QualityWorkCategory");

            migrationBuilder.AlterColumn<string>(
                name: "Details",
                table: "Services",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 350);

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "QualityWorks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Text",
                table: "News",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 500);

            migrationBuilder.CreateIndex(
                name: "IX_QualityWorks_CategoryId",
                table: "QualityWorks",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_QualityWorks_Categories_CategoryId",
                table: "QualityWorks",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

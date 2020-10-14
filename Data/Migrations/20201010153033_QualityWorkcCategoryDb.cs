using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class QualityWorkcCategoryDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QualityWorkCategory_Categories_CategoryId",
                table: "QualityWorkCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_QualityWorkCategory_QualityWorks_QualityWorkId",
                table: "QualityWorkCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_QualityWorkCategory",
                table: "QualityWorkCategory");

            migrationBuilder.RenameTable(
                name: "QualityWorkCategory",
                newName: "QualityWorkCategories");

            migrationBuilder.RenameIndex(
                name: "IX_QualityWorkCategory_QualityWorkId",
                table: "QualityWorkCategories",
                newName: "IX_QualityWorkCategories_QualityWorkId");

            migrationBuilder.RenameIndex(
                name: "IX_QualityWorkCategory_CategoryId",
                table: "QualityWorkCategories",
                newName: "IX_QualityWorkCategories_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_QualityWorkCategories",
                table: "QualityWorkCategories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_QualityWorkCategories_Categories_CategoryId",
                table: "QualityWorkCategories",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_QualityWorkCategories_QualityWorks_QualityWorkId",
                table: "QualityWorkCategories",
                column: "QualityWorkId",
                principalTable: "QualityWorks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QualityWorkCategories_Categories_CategoryId",
                table: "QualityWorkCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_QualityWorkCategories_QualityWorks_QualityWorkId",
                table: "QualityWorkCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_QualityWorkCategories",
                table: "QualityWorkCategories");

            migrationBuilder.RenameTable(
                name: "QualityWorkCategories",
                newName: "QualityWorkCategory");

            migrationBuilder.RenameIndex(
                name: "IX_QualityWorkCategories_QualityWorkId",
                table: "QualityWorkCategory",
                newName: "IX_QualityWorkCategory_QualityWorkId");

            migrationBuilder.RenameIndex(
                name: "IX_QualityWorkCategories_CategoryId",
                table: "QualityWorkCategory",
                newName: "IX_QualityWorkCategory_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_QualityWorkCategory",
                table: "QualityWorkCategory",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_QualityWorkCategory_Categories_CategoryId",
                table: "QualityWorkCategory",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_QualityWorkCategory_QualityWorks_QualityWorkId",
                table: "QualityWorkCategory",
                column: "QualityWorkId",
                principalTable: "QualityWorks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

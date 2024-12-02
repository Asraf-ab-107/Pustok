using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pustok_task_1.Migrations
{
    /// <inheritdoc />
    public partial class AddFirstImgColunmtoProductImage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstImgUrl",
                table: "ProductImages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstImgUrl",
                table: "ProductImages");
        }
    }
}

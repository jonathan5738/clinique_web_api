using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CliniqueBackend.Migrations
{
    /// <inheritdoc />
    public partial class AddedFieldToBlogPost : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ExcerptBody",
                table: "blog_posts",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "ExcerptTitle",
                table: "blog_posts",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExcerptBody",
                table: "blog_posts");

            migrationBuilder.DropColumn(
                name: "ExcerptTitle",
                table: "blog_posts");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CliniqueBackend.Migrations
{
    /// <inheritdoc />
    public partial class ChangedScheduleModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DayNumber",
                table: "schedules",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsSelected",
                table: "schedules",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DayNumber",
                table: "schedules");

            migrationBuilder.DropColumn(
                name: "IsSelected",
                table: "schedules");
        }
    }
}

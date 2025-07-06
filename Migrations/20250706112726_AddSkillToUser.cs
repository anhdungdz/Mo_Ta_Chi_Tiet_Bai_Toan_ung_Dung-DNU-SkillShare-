using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DashboardDaiNam.Migrations
{
    /// <inheritdoc />
    public partial class AddSkillToUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Skill",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Skill",
                table: "Users");
        }
    }
}

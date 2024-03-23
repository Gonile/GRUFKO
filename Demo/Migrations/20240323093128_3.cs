using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo.Migrations
{
    /// <inheritdoc />
    public partial class _3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Cost",
                table: "Stores",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Stores",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SpaceM3",
                table: "Stores",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UsageDurationYears",
                table: "Stores",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cost",
                table: "Stores");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Stores");

            migrationBuilder.DropColumn(
                name: "SpaceM3",
                table: "Stores");

            migrationBuilder.DropColumn(
                name: "UsageDurationYears",
                table: "Stores");
        }
    }
}

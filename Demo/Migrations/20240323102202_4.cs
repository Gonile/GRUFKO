using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo.Migrations
{
    /// <inheritdoc />
    public partial class _4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AvgBarnFieldDistance",
                table: "BaseData",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GrazingArea",
                table: "BaseData",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AvgBarnFieldDistance",
                table: "BaseData");

            migrationBuilder.DropColumn(
                name: "GrazingArea",
                table: "BaseData");
        }
    }
}

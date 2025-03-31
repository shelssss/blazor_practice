using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace practice_blazor.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedAppointment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ClientName",
                table: "Appointment",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "HoursRendered",
                table: "Appointment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ServiceSelected",
                table: "Appointment",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "TotalPrice",
                table: "Appointment",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClientName",
                table: "Appointment");

            migrationBuilder.DropColumn(
                name: "HoursRendered",
                table: "Appointment");

            migrationBuilder.DropColumn(
                name: "ServiceSelected",
                table: "Appointment");

            migrationBuilder.DropColumn(
                name: "TotalPrice",
                table: "Appointment");
        }
    }
}

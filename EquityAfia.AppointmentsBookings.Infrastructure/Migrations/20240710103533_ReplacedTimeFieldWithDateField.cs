using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EquityAfia.AppointmentsBookings.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ReplacedTimeFieldWithDateField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Time",
                table: "AppointmentBookings");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "AppointmentBookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "AppointmentBookings");

            migrationBuilder.AddColumn<TimeSpan>(
                name: "Time",
                table: "AppointmentBookings",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));
        }
    }
}

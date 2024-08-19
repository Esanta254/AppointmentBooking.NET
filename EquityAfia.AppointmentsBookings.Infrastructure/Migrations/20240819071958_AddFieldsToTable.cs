using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EquityAfia.AppointmentsBookings.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddFieldsToTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "AppointmentBookings");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "AppointmentBookings",
                newName: "AppointmentStatus");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "AppointmentBookings",
                newName: "Name");

            migrationBuilder.AddColumn<DateOnly>(
                name: "AppointmentDate",
                table: "AppointmentBookings",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<TimeOnly>(
                name: "AppointmentTime",
                table: "AppointmentBookings",
                type: "time",
                nullable: false,
                defaultValue: new TimeOnly(0, 0, 0));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "AppointmentBookings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PaymentSatus",
                table: "AppointmentBookings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "Not Paid");

            migrationBuilder.AddColumn<string>(
                name: "Residence",
                table: "AppointmentBookings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AppointmentDate",
                table: "AppointmentBookings");

            migrationBuilder.DropColumn(
                name: "AppointmentTime",
                table: "AppointmentBookings");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "AppointmentBookings");

            migrationBuilder.DropColumn(
                name: "PaymentSatus",
                table: "AppointmentBookings");

            migrationBuilder.DropColumn(
                name: "Residence",
                table: "AppointmentBookings");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "AppointmentBookings",
                newName: "FullName");

            migrationBuilder.RenameColumn(
                name: "AppointmentStatus",
                table: "AppointmentBookings",
                newName: "Status");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "AppointmentBookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}

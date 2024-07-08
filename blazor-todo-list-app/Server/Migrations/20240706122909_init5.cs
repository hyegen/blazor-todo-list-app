using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace blazortodolistapp.Server.Migrations
{
    /// <inheritdoc />
    public partial class init5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate_",
                value: new DateTime(2024, 7, 6, 15, 29, 9, 78, DateTimeKind.Local).AddTicks(8733));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate_",
                value: new DateTime(2024, 7, 6, 15, 29, 9, 78, DateTimeKind.Local).AddTicks(8743));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate_",
                value: new DateTime(2024, 7, 6, 15, 29, 9, 78, DateTimeKind.Local).AddTicks(8744));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate_",
                value: new DateTime(2024, 7, 6, 15, 29, 9, 78, DateTimeKind.Local).AddTicks(8745));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate_",
                value: new DateTime(2024, 7, 6, 15, 29, 9, 78, DateTimeKind.Local).AddTicks(8746));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate_",
                value: new DateTime(2024, 7, 6, 15, 29, 9, 78, DateTimeKind.Local).AddTicks(8747));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate_",
                value: new DateTime(2024, 7, 6, 10, 9, 58, 544, DateTimeKind.Local).AddTicks(372));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate_",
                value: new DateTime(2024, 7, 6, 10, 9, 58, 544, DateTimeKind.Local).AddTicks(381));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate_",
                value: new DateTime(2024, 7, 6, 10, 9, 58, 544, DateTimeKind.Local).AddTicks(383));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate_",
                value: new DateTime(2024, 7, 6, 10, 9, 58, 544, DateTimeKind.Local).AddTicks(384));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate_",
                value: new DateTime(2024, 7, 6, 10, 9, 58, 544, DateTimeKind.Local).AddTicks(385));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate_",
                value: new DateTime(2024, 7, 6, 10, 9, 58, 544, DateTimeKind.Local).AddTicks(386));
        }
    }
}

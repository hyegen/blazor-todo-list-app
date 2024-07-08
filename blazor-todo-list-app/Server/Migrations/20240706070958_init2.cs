using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace blazortodolistapp.Server.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate_ = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate_ = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CommentId = table.Column<int>(type: "int", nullable: true),
                    TaskName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Priority = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate_ = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate_ = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tasks_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    TaskId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CommentText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate_ = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate_ = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Tasks_Id",
                        column: x => x.Id,
                        principalTable: "Tasks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comments_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SubTasks",
                columns: table => new
                {
                    TaskId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubtaskName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaskUserId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    CreatedDate_ = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate_ = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubTasks", x => x.TaskId);
                    table.ForeignKey(
                        name: "FK_SubTasks_Tasks_TaskUserId",
                        column: x => x.TaskUserId,
                        principalTable: "Tasks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedDate_", "Email", "UpdatedDate_", "Username" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "hyegen205@gmail.com", null, "YEGEN" });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "CommentId", "CreatedDate_", "Description", "IsCompleted", "Priority", "Status", "TaskName", "UpdatedDate_", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 7, 6, 10, 9, 58, 544, DateTimeKind.Local).AddTicks(372), "Math homeworks will be continued.", false, null, 3, "Math Homework", null, 1 },
                    { 2, 2, new DateTime(2024, 7, 6, 10, 9, 58, 544, DateTimeKind.Local).AddTicks(381), "Description of PHYSC.", true, null, 2, "PHYSC Homework", null, 1 },
                    { 3, 3, new DateTime(2024, 7, 6, 10, 9, 58, 544, DateTimeKind.Local).AddTicks(383), "Hi from cpu :D.", true, null, 2, "Logic Circuits Homework", null, 1 },
                    { 4, null, new DateTime(2024, 7, 6, 10, 9, 58, 544, DateTimeKind.Local).AddTicks(384), "Buy new meal and others.", false, null, 1, "Go To Super Market", null, 1 },
                    { 5, null, new DateTime(2024, 7, 6, 10, 9, 58, 544, DateTimeKind.Local).AddTicks(385), "Wash dishes xxxx", false, null, 1, "Wash Dishes", null, 1 },
                    { 6, null, new DateTime(2024, 7, 6, 10, 9, 58, 544, DateTimeKind.Local).AddTicks(386), "Do vacuuming to home for a clean home :).", true, null, 2, "Vacuuming", null, 1 }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "CommentText", "CreatedDate_", "TaskId", "UpdatedDate_", "UserId" },
                values: new object[,]
                {
                    { 1, "(Task 1)What a nice Task Maaaan", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 1 },
                    { 2, "(Task 2)What a nice Task Maaaan", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, 1 },
                    { 3, "(Task 3)What a nice Task Maaaan", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserId",
                table: "Comments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SubTasks_TaskUserId",
                table: "SubTasks",
                column: "TaskUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_UserId",
                table: "Tasks",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "SubTasks");

            migrationBuilder.DropTable(
                name: "Tasks");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class Field_Changes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventUser_Users_Registered_UsersId",
                table: "EventUser");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Users",
                newName: "UserEmail");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Users",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "Registered_UsersId",
                table: "EventUser",
                newName: "Registered_UsersUserId");

            migrationBuilder.RenameIndex(
                name: "IX_EventUser_Registered_UsersId",
                table: "EventUser",
                newName: "IX_EventUser_Registered_UsersUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_EventUser_Users_Registered_UsersUserId",
                table: "EventUser",
                column: "Registered_UsersUserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventUser_Users_Registered_UsersUserId",
                table: "EventUser");

            migrationBuilder.RenameColumn(
                name: "UserEmail",
                table: "Users",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Users",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Registered_UsersUserId",
                table: "EventUser",
                newName: "Registered_UsersId");

            migrationBuilder.RenameIndex(
                name: "IX_EventUser_Registered_UsersUserId",
                table: "EventUser",
                newName: "IX_EventUser_Registered_UsersId");

            migrationBuilder.AddForeignKey(
                name: "FK_EventUser_Users_Registered_UsersId",
                table: "EventUser",
                column: "Registered_UsersId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

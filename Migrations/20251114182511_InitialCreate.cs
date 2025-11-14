using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Smart_Attendance_System.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Project",
                table: "EmployeeTasks");

            migrationBuilder.DropColumn(
                name: "Shift",
                table: "EmployeeTasks");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "EmployeeTasks");

            migrationBuilder.AddColumn<int>(
                name: "ProjectId",
                table: "EmployeeTasks",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ShiftId",
                table: "EmployeeTasks",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StatusId",
                table: "EmployeeTasks",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeTasks_ProjectId",
                table: "EmployeeTasks",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeTasks_ShiftId",
                table: "EmployeeTasks",
                column: "ShiftId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeTasks_StatusId",
                table: "EmployeeTasks",
                column: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeTasks_Enum_ProjectId",
                table: "EmployeeTasks",
                column: "ProjectId",
                principalTable: "Enum",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeTasks_Enum_ShiftId",
                table: "EmployeeTasks",
                column: "ShiftId",
                principalTable: "Enum",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeTasks_Enum_StatusId",
                table: "EmployeeTasks",
                column: "StatusId",
                principalTable: "Enum",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeTasks_Enum_ProjectId",
                table: "EmployeeTasks");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeTasks_Enum_ShiftId",
                table: "EmployeeTasks");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeTasks_Enum_StatusId",
                table: "EmployeeTasks");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeTasks_ProjectId",
                table: "EmployeeTasks");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeTasks_ShiftId",
                table: "EmployeeTasks");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeTasks_StatusId",
                table: "EmployeeTasks");

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "EmployeeTasks");

            migrationBuilder.DropColumn(
                name: "ShiftId",
                table: "EmployeeTasks");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "EmployeeTasks");

            migrationBuilder.AddColumn<string>(
                name: "Project",
                table: "EmployeeTasks",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Shift",
                table: "EmployeeTasks",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "EmployeeTasks",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}

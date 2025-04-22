using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaseVersion.Repository.Migrations
{
    /// <inheritdoc />
    public partial class dttypechange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobPositions_Departments_DepartmentId1",
                table: "JobPositions");

            migrationBuilder.DropIndex(
                name: "IX_JobPositions_DepartmentId1",
                table: "JobPositions");

            migrationBuilder.DropColumn(
                name: "DepartmentId1",
                table: "JobPositions");

            migrationBuilder.AlterColumn<string>(
                name: "DepartmentId",
                table: "JobPositions",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_JobPositions_DepartmentId",
                table: "JobPositions",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_JobPositions_Departments_DepartmentId",
                table: "JobPositions",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobPositions_Departments_DepartmentId",
                table: "JobPositions");

            migrationBuilder.DropIndex(
                name: "IX_JobPositions_DepartmentId",
                table: "JobPositions");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentId",
                table: "JobPositions",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "DepartmentId1",
                table: "JobPositions",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_JobPositions_DepartmentId1",
                table: "JobPositions",
                column: "DepartmentId1");

            migrationBuilder.AddForeignKey(
                name: "FK_JobPositions_Departments_DepartmentId1",
                table: "JobPositions",
                column: "DepartmentId1",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

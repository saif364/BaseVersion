using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaseVersion.Repository.Migrations
{
    /// <inheritdoc />
    public partial class tablesadd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContactInformations_Employees_EmployeeId1",
                table: "ContactInformations");

            migrationBuilder.DropForeignKey(
                name: "FK_EmploymentHistories_Employees_EmployeeId1",
                table: "EmploymentHistories");

            migrationBuilder.DropIndex(
                name: "IX_EmploymentHistories_EmployeeId1",
                table: "EmploymentHistories");

            migrationBuilder.DropIndex(
                name: "IX_ContactInformations_EmployeeId1",
                table: "ContactInformations");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "EmploymentHistories");

            migrationBuilder.DropColumn(
                name: "EmployeeId1",
                table: "EmploymentHistories");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "MaritalStatus",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Nationality",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "PhotoUrl",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "EmployeeId1",
                table: "ContactInformations");

            migrationBuilder.RenameColumn(
                name: "DateOfExit",
                table: "Employees",
                newName: "DateOfLeaving");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Employees",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "Employees",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Employees",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "BenefitId",
                table: "Employees",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DepartmentId",
                table: "Employees",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DisciplinaryActionId",
                table: "Employees",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Employees",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EmploymentStatusId",
                table: "Employees",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EmploymentTypeId",
                table: "Employees",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Employees",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "LocationId",
                table: "Employees",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PayGradeId",
                table: "Employees",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Employees",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ProjectId",
                table: "Employees",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SalaryStructureId",
                table: "Employees",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SkillId",
                table: "Employees",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SupervisorId",
                table: "Employees",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TeamId",
                table: "Employees",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TrainingCourseId",
                table: "Employees",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WorkShiftId",
                table: "Employees",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "EmployeeId",
                table: "ContactInformations",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    State = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    County = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    District = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Neighborhood = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ApartmentNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    BuildingNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Landmark = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Latitude = table.Column<double>(type: "float", nullable: true),
                    Longitude = table.Column<double>(type: "float", nullable: true),
                    AddressType = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ContactPhone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    ContactPerson = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsPrimary = table.Column<bool>(type: "bit", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmploymentStatuses",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    StatusName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmploymentStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WorkLocations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LocationName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AddressId1 = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkLocations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkLocations_Addresses_AddressId1",
                        column: x => x.AddressId1,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_BenefitId",
                table: "Employees",
                column: "BenefitId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentId",
                table: "Employees",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DisciplinaryActionId",
                table: "Employees",
                column: "DisciplinaryActionId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_EmploymentStatusId",
                table: "Employees",
                column: "EmploymentStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_EmploymentTypeId",
                table: "Employees",
                column: "EmploymentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_LocationId",
                table: "Employees",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_PayGradeId",
                table: "Employees",
                column: "PayGradeId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_ProjectId",
                table: "Employees",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_SalaryStructureId",
                table: "Employees",
                column: "SalaryStructureId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_SkillId",
                table: "Employees",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_SupervisorId",
                table: "Employees",
                column: "SupervisorId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_TeamId",
                table: "Employees",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_TrainingCourseId",
                table: "Employees",
                column: "TrainingCourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_WorkShiftId",
                table: "Employees",
                column: "WorkShiftId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkLocations_AddressId1",
                table: "WorkLocations",
                column: "AddressId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Benefits_BenefitId",
                table: "Employees",
                column: "BenefitId",
                principalTable: "Benefits",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_DepartmentId",
                table: "Employees",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_DisciplinaryActions_DisciplinaryActionId",
                table: "Employees",
                column: "DisciplinaryActionId",
                principalTable: "DisciplinaryActions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Employees_SupervisorId",
                table: "Employees",
                column: "SupervisorId",
                principalTable: "Employees",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_EmploymentStatuses_EmploymentStatusId",
                table: "Employees",
                column: "EmploymentStatusId",
                principalTable: "EmploymentStatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_EmploymentTypes_EmploymentTypeId",
                table: "Employees",
                column: "EmploymentTypeId",
                principalTable: "EmploymentTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Locations_LocationId",
                table: "Employees",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_PayGrades_PayGradeId",
                table: "Employees",
                column: "PayGradeId",
                principalTable: "PayGrades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Projects_ProjectId",
                table: "Employees",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_SalaryStructures_SalaryStructureId",
                table: "Employees",
                column: "SalaryStructureId",
                principalTable: "SalaryStructures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Skills_SkillId",
                table: "Employees",
                column: "SkillId",
                principalTable: "Skills",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Teams_TeamId",
                table: "Employees",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_TrainingCourses_TrainingCourseId",
                table: "Employees",
                column: "TrainingCourseId",
                principalTable: "TrainingCourses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_WorkShifts_WorkShiftId",
                table: "Employees",
                column: "WorkShiftId",
                principalTable: "WorkShifts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Benefits_BenefitId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_DepartmentId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_DisciplinaryActions_DisciplinaryActionId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Employees_SupervisorId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_EmploymentStatuses_EmploymentStatusId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_EmploymentTypes_EmploymentTypeId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Locations_LocationId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_PayGrades_PayGradeId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Projects_ProjectId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_SalaryStructures_SalaryStructureId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Skills_SkillId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Teams_TeamId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_TrainingCourses_TrainingCourseId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_WorkShifts_WorkShiftId",
                table: "Employees");

            migrationBuilder.DropTable(
                name: "EmploymentStatuses");

            migrationBuilder.DropTable(
                name: "Genders");

            migrationBuilder.DropTable(
                name: "WorkLocations");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropIndex(
                name: "IX_Employees_BenefitId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_DepartmentId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_DisciplinaryActionId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_EmploymentStatusId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_EmploymentTypeId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_LocationId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_PayGradeId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_ProjectId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_SalaryStructureId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_SkillId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_SupervisorId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_TeamId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_TrainingCourseId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_WorkShiftId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "BenefitId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "DisciplinaryActionId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "EmploymentStatusId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "EmploymentTypeId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "PayGradeId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "SalaryStructureId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "SkillId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "SupervisorId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "TeamId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "TrainingCourseId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "WorkShiftId",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "DateOfLeaving",
                table: "Employees",
                newName: "DateOfExit");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "EmploymentHistories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "EmployeeId1",
                table: "EmploymentHistories",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "MaritalStatus",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Nationality",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhotoUrl",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "ContactInformations",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "EmployeeId1",
                table: "ContactInformations",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmploymentHistories_EmployeeId1",
                table: "EmploymentHistories",
                column: "EmployeeId1");

            migrationBuilder.CreateIndex(
                name: "IX_ContactInformations_EmployeeId1",
                table: "ContactInformations",
                column: "EmployeeId1");

            migrationBuilder.AddForeignKey(
                name: "FK_ContactInformations_Employees_EmployeeId1",
                table: "ContactInformations",
                column: "EmployeeId1",
                principalTable: "Employees",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmploymentHistories_Employees_EmployeeId1",
                table: "EmploymentHistories",
                column: "EmployeeId1",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

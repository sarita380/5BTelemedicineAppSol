using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _5BTelemedicineApp.Data.Migrations
{
    public partial class secondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Appointment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false),
                    Time = table.Column<DateTime>(nullable: false),
                    PatientsId = table.Column<int>(nullable: false),
                    ProviderId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Appointment_Patients_PatientsId",
                        column: x => x.PatientsId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Appointment_Provider_ProviderId",
                        column: x => x.ProviderId,
                        principalTable: "Provider",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MyChartBook",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientsId = table.Column<int>(nullable: true),
                    ProviderId = table.Column<int>(nullable: true),
                    Message = table.Column<string>(nullable: true),
                    Diagnostic = table.Column<string>(nullable: true),
                    AppointmentId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyChartBook", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MyChartBook_Appointment_AppointmentId",
                        column: x => x.AppointmentId,
                        principalTable: "Appointment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MyChartBook_Patients_PatientsId",
                        column: x => x.PatientsId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MyChartBook_Provider_ProviderId",
                        column: x => x.ProviderId,
                        principalTable: "Provider",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_PatientsId",
                table: "Appointment",
                column: "PatientsId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_ProviderId",
                table: "Appointment",
                column: "ProviderId");

            migrationBuilder.CreateIndex(
                name: "IX_MyChartBook_AppointmentId",
                table: "MyChartBook",
                column: "AppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_MyChartBook_PatientsId",
                table: "MyChartBook",
                column: "PatientsId");

            migrationBuilder.CreateIndex(
                name: "IX_MyChartBook_ProviderId",
                table: "MyChartBook",
                column: "ProviderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MyChartBook");

            migrationBuilder.DropTable(
                name: "Appointment");
        }
    }
}

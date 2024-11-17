using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cafe.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cafes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    Location = table.Column<string>(type: "TEXT", maxLength: 250, nullable: false),
                    Logo = table.Column<string>(type: "TEXT", maxLength: 2000, nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cafes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    EmployeeId = table.Column<string>(type: "TEXT", maxLength: 9, nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    EmailAddress = table.Column<string>(type: "TEXT", nullable: false),
                    PhoneNumber = table.Column<string>(type: "TEXT", maxLength: 8, nullable: false),
                    Gender = table.Column<int>(type: "INTEGER", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CafeEmployees",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CafeId = table.Column<Guid>(type: "TEXT", nullable: false),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EndDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CafeEmployees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CafeEmployees_Cafes_CafeId",
                        column: x => x.CafeId,
                        principalTable: "Cafes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CafeEmployees_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cafes",
                columns: new[] { "Id", "CreatedDate", "Description", "IsActive", "Location", "Logo", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("a8f3c92a-2345-4e6d-915f-223344d4f74b"), new DateTime(2024, 11, 14, 15, 20, 25, 176, DateTimeKind.Utc).AddTicks(3967), "Modern cafe serving organic coffee and teas.", true, "456 Oak Avenue, Riverdale", "", null, "City Brew" },
                    { new Guid("c8f1c92a-1234-4e6d-915f-223344d4f73a"), new DateTime(2024, 11, 14, 15, 20, 25, 176, DateTimeKind.Utc).AddTicks(3963), "A cozy place with great coffee and pastries.", true, "123 Maple Street, Springfield", "", null, "Sunny Cafe" },
                    { new Guid("d9e4c92a-3456-4e6d-915f-223344d4f75c"), new DateTime(2024, 11, 14, 15, 20, 25, 176, DateTimeKind.Utc).AddTicks(4027), "Vegan-friendly cafe with a range of smoothies.", true, "789 Pine Road, Sunnyvale", "", null, "Green Leaf Cafe" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "CreatedDate", "EmailAddress", "EmployeeId", "Gender", "IsActive", "ModifiedDate", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("a1b2c3d4-e5f6-7890-1234-56789abcdef0"), new DateTime(2024, 11, 14, 15, 20, 25, 176, DateTimeKind.Utc).AddTicks(4034), "john.doe@gmail.com", "UI0000001", 0, true, null, "John Doe", "123-456-7890" },
                    { new Guid("b2c3d4e5-f6a7-8901-2345-67890abcdef1"), new DateTime(2024, 11, 14, 15, 20, 25, 176, DateTimeKind.Utc).AddTicks(4038), "jane.smith@gmail.com", "UI0000002", 1, true, null, "Ja Smith", "234-567-8901" },
                    { new Guid("c3d4e5f6-a7b8-9012-3456-7890abcdef12"), new DateTime(2024, 11, 14, 15, 20, 25, 176, DateTimeKind.Utc).AddTicks(4040), "alex.johnson@gmail.com", "UI0000003", 0, true, null, "Alex", "345-678-9012" },
                    { new Guid("d4e5f6a7-b8c9-0123-4567-890abcdef123"), new DateTime(2024, 11, 14, 15, 20, 25, 176, DateTimeKind.Utc).AddTicks(4042), "emily.davis@gmail.com", "UI0000004", 1, true, null, "Emily", "456-789-0123" },
                    { new Guid("e5f6a7b8-c9d0-1234-5678-90abcdef1234"), new DateTime(2024, 11, 14, 15, 20, 25, 176, DateTimeKind.Utc).AddTicks(4044), "daniel.brown@gmail.com", "UI0000005", 0, true, null, "Daniel", "567-890-1234" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CafeEmployees_CafeId",
                table: "CafeEmployees",
                column: "CafeId");

            migrationBuilder.CreateIndex(
                name: "IX_CafeEmployees_EmployeeId_IsActive",
                table: "CafeEmployees",
                columns: new[] { "EmployeeId", "IsActive" },
                unique: true,
                filter: "[IsActive] = 1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CafeEmployees");

            migrationBuilder.DropTable(
                name: "Cafes");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}

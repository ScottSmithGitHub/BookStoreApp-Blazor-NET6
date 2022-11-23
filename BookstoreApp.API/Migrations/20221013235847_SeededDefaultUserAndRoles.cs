using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookstoreApp.API.Migrations
{
    public partial class SeededDefaultUserAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0c708af3-382b-444e-806c-8c306e642532", "22d6ecc4-c6cc-4060-ab91-f67f5e177de3", "Administrator", "ADMINISTRATOR" },
                    { "0f11e99d-ac16-43ed-9399-89cfbe5eaff0", "08e06c0f-a0fc-4b8b-851a-ee536aee3830", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "23414c12-b51c-4e5f-9d36-2e2c9427a934", 0, "74430462-8587-4d4f-9773-a1ffe17f55fd", "admin@bookstore.com", false, "System", "Admin", false, null, "ADMIN@BOOKSTORE.COM", "ADMIN@BOOKSTORE.COM", "AQAAAAEAACcQAAAAECUaCyE+nDDeYMO+t+lNEDmwSu3w4Jqrugtos39d4KD5TditgDKJz+LF0u2kJIBVHg==", null, false, "8e0161d8-2e72-4d02-9986-a55e8396e47e", false, "admin@bookstore.com" },
                    { "3ef91889-1422-42e0-b80f-25fb54653c20", 0, "0dac5273-5056-4e65-be18-48fe0d4c8296", "user@bookstore.com", false, "System", "User", false, null, "USER@BOOKSTORE.COM", "USER@BOOKSTORE.COM", "AQAAAAEAACcQAAAAEA+my3cQAY0SA1iB7x2EXzJ72Ewvy/m9eAj7PVydwVggiaraR9+3DJHDPIb/8AkBpg==", null, false, "c0bacd54-83af-46c3-a79d-9db3d529249d", false, "user@bookstore.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "0c708af3-382b-444e-806c-8c306e642532", "23414c12-b51c-4e5f-9d36-2e2c9427a934" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "0f11e99d-ac16-43ed-9399-89cfbe5eaff0", "3ef91889-1422-42e0-b80f-25fb54653c20" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0c708af3-382b-444e-806c-8c306e642532", "23414c12-b51c-4e5f-9d36-2e2c9427a934" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0f11e99d-ac16-43ed-9399-89cfbe5eaff0", "3ef91889-1422-42e0-b80f-25fb54653c20" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c708af3-382b-444e-806c-8c306e642532");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f11e99d-ac16-43ed-9399-89cfbe5eaff0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23414c12-b51c-4e5f-9d36-2e2c9427a934");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3ef91889-1422-42e0-b80f-25fb54653c20");
        }
    }
}

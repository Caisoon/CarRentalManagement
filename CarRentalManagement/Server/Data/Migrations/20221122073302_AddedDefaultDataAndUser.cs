using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedDefaultDataAndUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "e773a991-eaa6-42c6-8b3f-20b556f351e5", "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "40ce7c36-4398-4836-acb1-8a7ad2be153f", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "fc7c13f4-a426-4b1f-8f37-126b5c023953", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN", "AQAAAAEAACcQAAAAEPLJCIs3Ol0qayHvZ1BURlupxTQTWXL03Kt4gZE95WOuUiW/7gxMf5YrroSY4U+PbA==", null, false, "03bf801d-63dd-420d-9a61-661fd1e0c731", false, "Admin" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 11, 22, 15, 33, 1, 788, DateTimeKind.Local).AddTicks(87), new DateTime(2022, 11, 22, 15, 33, 1, 789, DateTimeKind.Local).AddTicks(5602), "Black", "System" },
                    { 2, "System", new DateTime(2022, 11, 22, 15, 33, 1, 789, DateTimeKind.Local).AddTicks(6152), new DateTime(2022, 11, 22, 15, 33, 1, 789, DateTimeKind.Local).AddTicks(6156), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 11, 22, 15, 33, 1, 791, DateTimeKind.Local).AddTicks(29), new DateTime(2022, 11, 22, 15, 33, 1, 791, DateTimeKind.Local).AddTicks(35), "BMW", "System" },
                    { 2, "System", new DateTime(2022, 11, 22, 15, 33, 1, 791, DateTimeKind.Local).AddTicks(37), new DateTime(2022, 11, 22, 15, 33, 1, 791, DateTimeKind.Local).AddTicks(38), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 11, 22, 15, 33, 1, 790, DateTimeKind.Local).AddTicks(7649), new DateTime(2022, 11, 22, 15, 33, 1, 790, DateTimeKind.Local).AddTicks(7693), "3 Series", "System" },
                    { 2, "System", new DateTime(2022, 11, 22, 15, 33, 1, 790, DateTimeKind.Local).AddTicks(7696), new DateTime(2022, 11, 22, 15, 33, 1, 790, DateTimeKind.Local).AddTicks(7697), "X5", "System" },
                    { 3, "System", new DateTime(2022, 11, 22, 15, 33, 1, 790, DateTimeKind.Local).AddTicks(7699), new DateTime(2022, 11, 22, 15, 33, 1, 790, DateTimeKind.Local).AddTicks(7700), "Prius", "System" },
                    { 4, "System", new DateTime(2022, 11, 22, 15, 33, 1, 790, DateTimeKind.Local).AddTicks(7701), new DateTime(2022, 11, 22, 15, 33, 1, 790, DateTimeKind.Local).AddTicks(7702), "Rav4", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");
        }
    }
}

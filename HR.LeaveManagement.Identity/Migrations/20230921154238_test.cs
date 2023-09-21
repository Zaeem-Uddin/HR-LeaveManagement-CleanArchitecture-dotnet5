using Microsoft.EntityFrameworkCore.Migrations;

namespace HR.LeaveManagement.Identity.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "6a295d38-5146-4f1e-b8e1-ef550e952148");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "6ed67781-b676-4eff-bdba-22f4f4a94d2f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "45d198ad-4f0b-46e0-8384-fd2632dae037", "AQAAAAEAACcQAAAAEHSaps1f4FK7zCM0dgtzlQP3kWxxXt5+PIABGMzlv9LgTJTpXJ+zzdlRUpgTxyHa6w==", "a016a5e8-e5c8-4db8-bd92-da8525a5f1f6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "96b7194c-7788-43b6-a363-6b001262a602", "AQAAAAEAACcQAAAAEIA7/j+X2PGsWOnnAp+S3uHewwNOL2HZeuy6GzHHNO3WbdcowsJGm66qFjoHFyFAEw==", "7164508a-b48c-4e90-a30a-51e427fa88af" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "68bb5593-dfd4-4951-a3b0-5fe5788ebde4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "d11f9641-113b-4d94-9505-35d91cc7f298");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d2cedf01-cee0-430a-b820-0c377b586c0a", "AQAAAAEAACcQAAAAEN/+QPuA+uuzTXrdYR7YF0/+JPxiPmjUY/ukh+lBiXnLyMcVGwVaQDSrcginM2gbtA==", "b0bc8cba-dbe5-49c1-b77c-108c1dcccacc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "49ff2dd4-d01a-42bb-afb8-83202db83269", "AQAAAAEAACcQAAAAEEnH3am4iXtp/eOTCv2+/TfcX6lIU9iYzudCAZkuGPuPyHjO8/6+fUwUX0kZfjZj3A==", "a039aaef-c811-4cc7-a4e3-42092c879d08" });
        }
    }
}

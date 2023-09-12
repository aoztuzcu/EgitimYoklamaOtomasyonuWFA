using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EgitimYoklamaOtomasyonu.DAL.Migrations
{
    /// <inheritdoc />
    public partial class editSube : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Subeler",
                columns: new[] { "Id", "Adi", "Adres", "Mail", "SilenId", "SilindiMi", "Telefon", "YaraticiId", "YaratilmaZamani" },
                values: new object[] { 1, "", "", "", 0, false, "", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Subeler",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}

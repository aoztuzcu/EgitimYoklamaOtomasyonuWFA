using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EgitimYoklamaOtomasyonu.DAL.Migrations
{
    /// <inheritdoc />
    public partial class editKullanici : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Kullanicilar",
                columns: new[] { "Id", "Adi", "DogumTarihi", "FotografAdresi", "KullaniciTipi", "Mail", "Parola", "SilenId", "SilindiMi", "SoyAdi", "SubeID", "Telefon", "YaraticiId", "YaratilmaZamani" },
                values: new object[,]
                {
                    { -3, "e", null, null, 2, "e", "e", 0, false, "e", 1, "000", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -2, "k", null, null, 1, "k", "k", 0, false, "k", 1, "000", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -1, "admin", null, null, 0, "admin", "admin", 0, false, "admin", 1, "000", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "Id",
                keyValue: -1);
        }
    }
}

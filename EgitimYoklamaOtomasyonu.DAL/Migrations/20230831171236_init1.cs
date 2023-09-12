using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EgitimYoklamaOtomasyonu.DAL.Migrations
{
    /// <inheritdoc />
    public partial class init1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Egitimler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ToplamSure = table.Column<int>(type: "int", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SilindiMi = table.Column<bool>(type: "bit", nullable: false),
                    SilenId = table.Column<int>(type: "int", nullable: false),
                    YaratilmaZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    YaraticiId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Egitimler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subeler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SilindiMi = table.Column<bool>(type: "bit", nullable: false),
                    SilenId = table.Column<int>(type: "int", nullable: false),
                    YaratilmaZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    YaraticiId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subeler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kullanicilar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoyAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DogumTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FotografAdresi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Parola = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KullaniciTipi = table.Column<int>(type: "int", nullable: false),
                    SubeID = table.Column<int>(type: "int", nullable: false),
                    SilindiMi = table.Column<bool>(type: "bit", nullable: false),
                    SilenId = table.Column<int>(type: "int", nullable: false),
                    YaratilmaZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    YaraticiId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanicilar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kullanicilar_Subeler_SubeID",
                        column: x => x.SubeID,
                        principalTable: "Subeler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KullaniciGirisler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciId = table.Column<int>(type: "int", nullable: false),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KullaniciGirisler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KullaniciGirisler_Kullanicilar_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanicilar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Siniflar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BaslangicTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BitisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SubeId = table.Column<int>(type: "int", nullable: false),
                    EgitmenId = table.Column<int>(type: "int", nullable: false),
                    EgitimId = table.Column<int>(type: "int", nullable: false),
                    SilindiMi = table.Column<bool>(type: "bit", nullable: false),
                    SilenId = table.Column<int>(type: "int", nullable: false),
                    YaratilmaZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    YaraticiId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Siniflar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Siniflar_Egitimler_EgitimId",
                        column: x => x.EgitimId,
                        principalTable: "Egitimler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Siniflar_Kullanicilar_EgitmenId",
                        column: x => x.EgitmenId,
                        principalTable: "Kullanicilar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Siniflar_Subeler_SubeId",
                        column: x => x.SubeId,
                        principalTable: "Subeler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ogrenciler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoyAd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SinifId = table.Column<int>(type: "int", nullable: false),
                    SilindiMi = table.Column<bool>(type: "bit", nullable: false),
                    SilenId = table.Column<int>(type: "int", nullable: false),
                    YaratilmaZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    YaraticiId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogrenciler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ogrenciler_Siniflar_SinifId",
                        column: x => x.SinifId,
                        principalTable: "Siniflar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SinifDersGunler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SinifId = table.Column<int>(type: "int", nullable: false),
                    Gun = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GunlukSaat = table.Column<int>(type: "int", nullable: false),
                    SilindiMi = table.Column<bool>(type: "bit", nullable: false),
                    SilenId = table.Column<int>(type: "int", nullable: false),
                    YaratilmaZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    YaraticiId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SinifDersGunler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SinifDersGunler_Siniflar_SinifId",
                        column: x => x.SinifId,
                        principalTable: "Siniflar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OgrenciYoklamalar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OgrenciId = table.Column<int>(type: "int", nullable: false),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GunlukKatılımYuzdesi = table.Column<int>(type: "int", nullable: false),
                    SilindiMi = table.Column<bool>(type: "bit", nullable: false),
                    SilenId = table.Column<int>(type: "int", nullable: false),
                    YaratilmaZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    YaraticiId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OgrenciYoklamalar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OgrenciYoklamalar_Ogrenciler_OgrenciId",
                        column: x => x.OgrenciId,
                        principalTable: "Ogrenciler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Yoklamalar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DersSaati = table.Column<int>(type: "int", nullable: false),
                    GirdiMi = table.Column<bool>(type: "bit", nullable: false),
                    OgrenciYoklamaID = table.Column<int>(type: "int", nullable: false),
                    SilindiMi = table.Column<bool>(type: "bit", nullable: false),
                    SilenId = table.Column<int>(type: "int", nullable: false),
                    YaratilmaZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    YaraticiId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yoklamalar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Yoklamalar_OgrenciYoklamalar_OgrenciYoklamaID",
                        column: x => x.OgrenciYoklamaID,
                        principalTable: "OgrenciYoklamalar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_KullaniciGirisler_KullaniciId",
                table: "KullaniciGirisler",
                column: "KullaniciId");

            migrationBuilder.CreateIndex(
                name: "IX_Kullanicilar_SubeID",
                table: "Kullanicilar",
                column: "SubeID");

            migrationBuilder.CreateIndex(
                name: "IX_Ogrenciler_SinifId",
                table: "Ogrenciler",
                column: "SinifId");

            migrationBuilder.CreateIndex(
                name: "IX_OgrenciYoklamalar_OgrenciId",
                table: "OgrenciYoklamalar",
                column: "OgrenciId");

            migrationBuilder.CreateIndex(
                name: "IX_SinifDersGunler_SinifId",
                table: "SinifDersGunler",
                column: "SinifId");

            migrationBuilder.CreateIndex(
                name: "IX_Siniflar_EgitimId",
                table: "Siniflar",
                column: "EgitimId");

            migrationBuilder.CreateIndex(
                name: "IX_Siniflar_EgitmenId",
                table: "Siniflar",
                column: "EgitmenId");

            migrationBuilder.CreateIndex(
                name: "IX_Siniflar_SubeId",
                table: "Siniflar",
                column: "SubeId");

            migrationBuilder.CreateIndex(
                name: "IX_Yoklamalar_OgrenciYoklamaID",
                table: "Yoklamalar",
                column: "OgrenciYoklamaID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KullaniciGirisler");

            migrationBuilder.DropTable(
                name: "SinifDersGunler");

            migrationBuilder.DropTable(
                name: "Yoklamalar");

            migrationBuilder.DropTable(
                name: "OgrenciYoklamalar");

            migrationBuilder.DropTable(
                name: "Ogrenciler");

            migrationBuilder.DropTable(
                name: "Siniflar");

            migrationBuilder.DropTable(
                name: "Egitimler");

            migrationBuilder.DropTable(
                name: "Kullanicilar");

            migrationBuilder.DropTable(
                name: "Subeler");
        }
    }
}

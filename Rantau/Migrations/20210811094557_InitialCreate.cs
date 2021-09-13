using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Rantau.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "historiPesan",
                columns: table => new
                {
                    HistoriPesanID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SumberPesan = table.Column<int>(type: "integer", nullable: false),
                    NoTelepon = table.Column<string>(type: "text", nullable: true),
                    NamaSapaan = table.Column<string>(type: "text", nullable: true),
                    NamaPasien = table.Column<string>(type: "text", nullable: true),
                    JarakAnjuran = table.Column<string>(type: "text", nullable: true),
                    IsiPesan = table.Column<string>(type: "text", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_historiPesan", x => x.HistoriPesanID);
                });

            migrationBuilder.CreateTable(
                name: "pasien",
                columns: table => new
                {
                    PasienID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NoRekamMedis = table.Column<string>(type: "text", nullable: false),
                    NamaDepan = table.Column<string>(type: "text", nullable: false),
                    NamaBelakang = table.Column<string>(type: "text", nullable: true),
                    TanggalLahir = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    JenisKelamin = table.Column<int>(type: "integer", nullable: false),
                    Alamat = table.Column<string>(type: "text", nullable: false),
                    NoTeleponUtama = table.Column<string>(type: "text", nullable: false),
                    NoTeleponAlternatif = table.Column<string>(type: "text", nullable: true),
                    JenisPembayaran = table.Column<int>(type: "integer", nullable: false),
                    StatusPernikahan = table.Column<int>(type: "integer", nullable: false),
                    TingkatPendidikan = table.Column<int>(type: "integer", nullable: false),
                    RiwayatMerokok = table.Column<int>(type: "integer", nullable: false),
                    WaktuTempuhRS = table.Column<int>(type: "integer", nullable: false),
                    Pemeriksa = table.Column<string>(type: "text", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pasien", x => x.PasienID);
                });

            migrationBuilder.CreateTable(
                name: "templatPesan",
                columns: table => new
                {
                    TemplatePesanID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TemplatePesanCode = table.Column<string>(type: "text", nullable: true),
                    TemplatePesanDescription = table.Column<string>(type: "text", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_templatPesan", x => x.TemplatePesanID);
                });

            migrationBuilder.CreateTable(
                name: "infoRekamMedis",
                columns: table => new
                {
                    InfoRekamMedisID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NoRekamMedis = table.Column<string>(type: "text", nullable: true),
                    TanggalPemeriksaan = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    BeratBadan = table.Column<decimal>(type: "numeric", nullable: false),
                    TinggiBadan = table.Column<decimal>(type: "numeric", nullable: false),
                    IndeksMassaTubuh = table.Column<decimal>(type: "numeric", nullable: false),
                    DenyutNadi = table.Column<decimal>(type: "numeric", nullable: false),
                    TekananDarah = table.Column<decimal>(type: "numeric", nullable: false),
                    Saturasi = table.Column<decimal>(type: "numeric", nullable: false),
                    JarakUjiJalan = table.Column<decimal>(type: "numeric", nullable: false),
                    JarakUjiWaktu = table.Column<int>(type: "integer", nullable: false),
                    VO2Max = table.Column<decimal>(type: "numeric", nullable: false),
                    METs = table.Column<decimal>(type: "numeric", nullable: false),
                    Pemeriksa = table.Column<string>(type: "text", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    PasienID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_infoRekamMedis", x => x.InfoRekamMedisID);
                    table.ForeignKey(
                        name: "FK_infoRekamMedis_pasien_PasienID",
                        column: x => x.PasienID,
                        principalTable: "pasien",
                        principalColumn: "PasienID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_infoRekamMedis_PasienID",
                table: "infoRekamMedis",
                column: "PasienID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "historiPesan");

            migrationBuilder.DropTable(
                name: "infoRekamMedis");

            migrationBuilder.DropTable(
                name: "templatPesan");

            migrationBuilder.DropTable(
                name: "pasien");
        }
    }
}

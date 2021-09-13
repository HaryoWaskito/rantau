﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Rantau.DAL;

namespace Rantau.Migrations
{
    [DbContext(typeof(RantauContext))]
    partial class RantauContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("Rantau.Models.HistoriPesan", b =>
                {
                    b.Property<int>("HistoriPesanID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("IsiPesan")
                        .HasColumnType("text");

                    b.Property<string>("JarakAnjuran")
                        .HasColumnType("text");

                    b.Property<string>("NamaPasien")
                        .HasColumnType("text");

                    b.Property<string>("NamaSapaan")
                        .HasColumnType("text");

                    b.Property<string>("NoTelepon")
                        .HasColumnType("text");

                    b.Property<int>("SumberPesan")
                        .HasColumnType("integer");

                    b.HasKey("HistoriPesanID");

                    b.ToTable("historiPesan");
                });

            modelBuilder.Entity("Rantau.Models.InfoRekamMedis", b =>
                {
                    b.Property<int>("InfoRekamMedisID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<decimal>("BeratBadan")
                        .HasColumnType("numeric");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<decimal>("DenyutNadi")
                        .HasColumnType("numeric");

                    b.Property<decimal>("IndeksMassaTubuh")
                        .HasColumnType("numeric");

                    b.Property<decimal>("JarakUjiJalan")
                        .HasColumnType("numeric");

                    b.Property<int>("JarakUjiWaktu")
                        .HasColumnType("integer");

                    b.Property<decimal>("METs")
                        .HasColumnType("numeric");

                    b.Property<string>("NoRekamMedis")
                        .HasColumnType("text");

                    b.Property<int?>("PasienID")
                        .HasColumnType("integer");

                    b.Property<string>("Pemeriksa")
                        .HasColumnType("text");

                    b.Property<decimal>("Saturasi")
                        .HasColumnType("numeric");

                    b.Property<DateTime>("TanggalPemeriksaan")
                        .HasColumnType("timestamp without time zone");

                    b.Property<decimal>("TekananDarah")
                        .HasColumnType("numeric");

                    b.Property<decimal>("TinggiBadan")
                        .HasColumnType("numeric");

                    b.Property<decimal>("VO2Max")
                        .HasColumnType("numeric");

                    b.HasKey("InfoRekamMedisID");

                    b.HasIndex("PasienID");

                    b.ToTable("infoRekamMedis");
                });

            modelBuilder.Entity("Rantau.Models.Pasien", b =>
                {
                    b.Property<int>("PasienID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Alamat")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("JenisKelamin")
                        .HasColumnType("integer");

                    b.Property<int>("JenisPembayaran")
                        .HasColumnType("integer");

                    b.Property<string>("NamaBelakang")
                        .HasColumnType("text");

                    b.Property<string>("NamaDepan")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NoRekamMedis")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NoTeleponAlternatif")
                        .HasColumnType("text");

                    b.Property<string>("NoTeleponUtama")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Pemeriksa")
                        .HasColumnType("text");

                    b.Property<int>("RiwayatMerokok")
                        .HasColumnType("integer");

                    b.Property<int>("StatusPernikahan")
                        .HasColumnType("integer");

                    b.Property<DateTime>("TanggalLahir")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("TingkatPendidikan")
                        .HasColumnType("integer");

                    b.Property<int>("WaktuTempuhRS")
                        .HasColumnType("integer");

                    b.HasKey("PasienID");

                    b.ToTable("pasien");
                });

            modelBuilder.Entity("Rantau.Models.TemplatPesan", b =>
                {
                    b.Property<int>("TemplatePesanID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("TemplatePesanCode")
                        .HasColumnType("text");

                    b.Property<string>("TemplatePesanDescription")
                        .HasColumnType("text");

                    b.HasKey("TemplatePesanID");

                    b.ToTable("templatPesan");
                });

            modelBuilder.Entity("Rantau.Models.InfoRekamMedis", b =>
                {
                    b.HasOne("Rantau.Models.Pasien", null)
                        .WithMany("InfoRekamMedis")
                        .HasForeignKey("PasienID");
                });

            modelBuilder.Entity("Rantau.Models.Pasien", b =>
                {
                    b.Navigation("InfoRekamMedis");
                });
#pragma warning restore 612, 618
        }
    }
}

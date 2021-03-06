// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RentACar.Data;

namespace RentACar.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RentACar.Core.Models.Alici", b =>
                {
                    b.Property<int>("AliciID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Adres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CepTel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("KiralamaID")
                        .HasColumnType("int");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TCKimlikNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AliciID");

                    b.HasIndex("KiralamaID");

                    b.ToTable("Alici");

                    b.HasData(
                        new
                        {
                            AliciID = 1,
                            Ad = "Sukru",
                            Adres = "Bornova İzmir",
                            CepTel = "2423",
                            Mail = "Sukru@gmail.com",
                            Soyad = "Sukru Sukru",
                            TCKimlikNo = "54654"
                        },
                        new
                        {
                            AliciID = 2,
                            Ad = "Omer",
                            Adres = "Bornova İzmir",
                            CepTel = "05",
                            Mail = "Omer@gmail.com",
                            Soyad = "Omer",
                            TCKimlikNo = "23423"
                        },
                        new
                        {
                            AliciID = 3,
                            Ad = "Hilal",
                            Adres = "Bornova İzmir",
                            CepTel = "33",
                            Mail = "Hilal@gmail.com",
                            Soyad = "Hilal",
                            TCKimlikNo = "534534"
                        });
                });

            modelBuilder.Entity("RentACar.Core.Models.Araba", b =>
                {
                    b.Property<int>("ArabaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EhliyetSinifi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FirmaID")
                        .HasColumnType("int");

                    b.Property<decimal>("GunlukUcret")
                        .HasColumnType("decimal");

                    b.Property<int?>("KiralamaID")
                        .HasColumnType("int");

                    b.Property<int>("KoltukSayisi")
                        .HasColumnType("int");

                    b.Property<string>("Marka")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Plaka")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UretimYili")
                        .HasColumnType("int");

                    b.Property<string>("YakitTuru")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ArabaID");

                    b.HasIndex("FirmaID");

                    b.HasIndex("KiralamaID");

                    b.ToTable("Araba");

                    b.HasData(
                        new
                        {
                            ArabaID = 1,
                            EhliyetSinifi = "B",
                            FirmaID = 1,
                            GunlukUcret = 50m,
                            KoltukSayisi = 5,
                            Marka = "Tofaş",
                            Model = "Doğan",
                            Plaka = "43HD101",
                            UretimYili = 1995,
                            YakitTuru = "Benzin"
                        },
                        new
                        {
                            ArabaID = 2,
                            EhliyetSinifi = "B",
                            FirmaID = 2,
                            GunlukUcret = 150m,
                            KoltukSayisi = 5,
                            Marka = "Wolksvagen",
                            Model = "Polo",
                            Plaka = "34FP8146",
                            UretimYili = 2012,
                            YakitTuru = "Dizel"
                        },
                        new
                        {
                            ArabaID = 3,
                            EhliyetSinifi = "B",
                            FirmaID = 3,
                            GunlukUcret = 75m,
                            KoltukSayisi = 5,
                            Marka = "Tofaş",
                            Model = "Şahin",
                            Plaka = "35EHT84",
                            UretimYili = 2000,
                            YakitTuru = "Benzin"
                        },
                        new
                        {
                            ArabaID = 4,
                            EhliyetSinifi = "B",
                            FirmaID = 2,
                            GunlukUcret = 200m,
                            KoltukSayisi = 5,
                            Marka = "BMV",
                            Model = "1.16",
                            Plaka = "35FST17",
                            UretimYili = 2016,
                            YakitTuru = "Dizel"
                        });
                });

            modelBuilder.Entity("RentACar.Core.Models.Firma", b =>
                {
                    b.Property<int>("FirmaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Unvan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VergiNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FirmaID");

                    b.ToTable("Firma");

                    b.HasData(
                        new
                        {
                            FirmaID = 1,
                            Adres = "Bornova",
                            Mail = "Bornova@Bornova.com",
                            Telefon = "234234",
                            Unvan = "Bornova",
                            VergiNo = "Bornova32"
                        },
                        new
                        {
                            FirmaID = 2,
                            Adres = "Sukruler",
                            Mail = "Sukruler@gmail.com",
                            Telefon = "0326569",
                            Unvan = "Sukruler",
                            VergiNo = "Sukruler22"
                        },
                        new
                        {
                            FirmaID = 3,
                            Adres = "Hoba",
                            Mail = "Hoba@gmail.com",
                            Telefon = "3534",
                            Unvan = "Hoba",
                            VergiNo = "Hoba3423"
                        });
                });

            modelBuilder.Entity("RentACar.Core.Models.Kiralama", b =>
                {
                    b.Property<int>("KiralamaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AliciID")
                        .HasColumnType("int");

                    b.Property<int>("ArabaID")
                        .HasColumnType("int");

                    b.Property<DateTime>("BaslangicTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("BitisTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("TeslimTarihi")
                        .HasColumnType("datetime2");

                    b.HasKey("KiralamaID");

                    b.ToTable("Kiralama");

                    b.HasData(
                        new
                        {
                            KiralamaID = 1,
                            AliciID = 1,
                            ArabaID = 1,
                            BaslangicTarihi = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BitisTarihi = new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            KiralamaID = 2,
                            AliciID = 2,
                            ArabaID = 2,
                            BaslangicTarihi = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BitisTarihi = new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            KiralamaID = 3,
                            AliciID = 3,
                            ArabaID = 3,
                            BaslangicTarihi = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BitisTarihi = new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("RentACar.Core.Models.Alici", b =>
                {
                    b.HasOne("RentACar.Core.Models.Kiralama", null)
                        .WithMany("Alicis")
                        .HasForeignKey("KiralamaID");
                });

            modelBuilder.Entity("RentACar.Core.Models.Araba", b =>
                {
                    b.HasOne("RentACar.Core.Models.Firma", "Firma")
                        .WithMany("Arabas")
                        .HasForeignKey("FirmaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RentACar.Core.Models.Kiralama", null)
                        .WithMany("Arabas")
                        .HasForeignKey("KiralamaID");

                    b.Navigation("Firma");
                });

            modelBuilder.Entity("RentACar.Core.Models.Firma", b =>
                {
                    b.Navigation("Arabas");
                });

            modelBuilder.Entity("RentACar.Core.Models.Kiralama", b =>
                {
                    b.Navigation("Alicis");

                    b.Navigation("Arabas");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using eStanica.Data;

namespace eStanica.Data.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20190128182306_popravljenaVezaKartePosjecujeLokacije")]
    partial class popravljenaVezaKartePosjecujeLokacije
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("eStanica.Data.Models.Autobus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Proizvodjac");

                    b.Property<int>("brojSjedistaBusa");

                    b.Property<byte[]>("slikaAutobusa");

                    b.Property<string>("vrstaBusa");

                    b.HasKey("Id");

                    b.ToTable("Autobusi");
                });

            modelBuilder.Entity("eStanica.Data.Models.Drzava", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Drzave");
                });

            modelBuilder.Entity("eStanica.Data.Models.Grad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DrzavaId");

                    b.Property<string>("Naziv");

                    b.HasKey("Id");

                    b.HasIndex("DrzavaId");

                    b.ToTable("Gradovi");
                });

            modelBuilder.Entity("eStanica.Data.Models.Karta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Aktivna");

                    b.Property<string>("BrojKarte");

                    b.Property<int>("PosjecujeLokacijeId");

                    b.Property<int>("TipKarteId");

                    b.Property<string>("brojSjedista");

                    b.Property<DateTime>("datumPutovanja");

                    b.HasKey("Id");

                    b.HasIndex("PosjecujeLokacijeId");

                    b.HasIndex("TipKarteId");

                    b.ToTable("Karte");
                });

            modelBuilder.Entity("eStanica.Data.Models.Kartica", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Banka");

                    b.Property<string>("BrojKartice");

                    b.Property<int>("SredstvoPlacanjaId");

                    b.Property<float>("StanjeRacuna");

                    b.Property<DateTime>("datumIsteka");

                    b.Property<string>("vrstaKartice");

                    b.HasKey("Id");

                    b.HasIndex("SredstvoPlacanjaId");

                    b.ToTable("Kartice");
                });

            modelBuilder.Entity("eStanica.Data.Models.Korisnik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adresa");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Email");

                    b.Property<string>("Grad");

                    b.Property<string>("Ime");

                    b.Property<string>("Prezime");

                    b.Property<string>("Spol")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 1)));

                    b.Property<string>("Telefon");

                    b.Property<int>("UlogeId");

                    b.Property<string>("Zanimanje");

                    b.Property<string>("ZemljaPorijekla");

                    b.Property<DateTime>("datumRodjenja");

                    b.Property<bool>("isValid");

                    b.Property<string>("password");

                    b.Property<string>("username");

                    b.HasKey("Id");

                    b.HasIndex("UlogeId");

                    b.ToTable("Korisnici");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Korisnik");
                });

            modelBuilder.Entity("eStanica.Data.Models.KretanjeAutobusa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AutobusId");

                    b.Property<int>("LinijeId");

                    b.Property<float>("TrajanjePuta");

                    b.Property<DateTime>("vrijemePolaska");

                    b.HasKey("Id");

                    b.HasIndex("AutobusId");

                    b.HasIndex("LinijeId");

                    b.ToTable("KretanjeAutobusa");
                });

            modelBuilder.Entity("eStanica.Data.Models.Linije", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DestinacijaId");

                    b.Property<string>("Naziv");

                    b.Property<int>("PolazakId");

                    b.Property<int>("PrevoznikId");

                    b.Property<string>("RedniBrojLinije");

                    b.Property<string>("TipLinije");

                    b.Property<string>("vrijemePolaska");

                    b.HasKey("Id");

                    b.HasIndex("DestinacijaId");

                    b.HasIndex("PolazakId");

                    b.HasIndex("PrevoznikId");

                    b.ToTable("Linije");
                });

            modelBuilder.Entity("eStanica.Data.Models.Popust", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("Postotak");

                    b.Property<string>("vrstaPopusta");

                    b.HasKey("Id");

                    b.ToTable("Popusti");
                });

            modelBuilder.Entity("eStanica.Data.Models.PosjecujeLokacije", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GradId");

                    b.Property<int>("LinijeId");

                    b.Property<float>("cijenaOdPolaska");

                    b.Property<string>("vrijemeDolaska");

                    b.HasKey("Id");

                    b.HasIndex("GradId");

                    b.HasIndex("LinijeId");

                    b.ToTable("PosjecujeLokacije");
                });

            modelBuilder.Entity("eStanica.Data.Models.PosjedujeAutobuse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AutobusId");

                    b.Property<int>("PrevoznikId");

                    b.HasKey("Id");

                    b.HasIndex("AutobusId");

                    b.HasIndex("PrevoznikId");

                    b.ToTable("PosjedujeAutobuse");
                });

            modelBuilder.Entity("eStanica.Data.Models.Prevoznik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("KontaktTelefon");

                    b.Property<string>("Naziv");

                    b.Property<string>("webStranica");

                    b.HasKey("Id");

                    b.ToTable("Prevoznici");
                });

            modelBuilder.Entity("eStanica.Data.Models.Recenzija", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("KartaId");

                    b.Property<int?>("KlijentId");

                    b.Property<int?>("KlijentiId");

                    b.Property<string>("Komentar");

                    b.Property<int>("Ocjena");

                    b.Property<string>("Opis");

                    b.HasKey("Id");

                    b.HasIndex("KartaId");

                    b.HasIndex("KlijentiId");

                    b.ToTable("Recenzije");
                });

            modelBuilder.Entity("eStanica.Data.Models.SaobracajniDnevnik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Primjedbe");

                    b.Property<int>("StanicaId");

                    b.Property<int>("UposlenikId");

                    b.Property<string>("Zakasnjenje");

                    b.Property<string>("brojPutnogNaloga");

                    b.Property<DateTime>("vrijemeDolaska");

                    b.Property<DateTime>("vrijemeOdlaska");

                    b.HasKey("Id");

                    b.HasIndex("StanicaId");

                    b.HasIndex("UposlenikId");

                    b.ToTable("SaobracajniDnevnik");
                });

            modelBuilder.Entity("eStanica.Data.Models.SredstvoPlacanja", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Tip");

                    b.HasKey("Id");

                    b.ToTable("SredstvoPlacanja");
                });

            modelBuilder.Entity("eStanica.Data.Models.Stanica", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GradId");

                    b.Property<string>("Naziv");

                    b.HasKey("Id");

                    b.HasIndex("GradId");

                    b.ToTable("Stanice");
                });

            modelBuilder.Entity("eStanica.Data.Models.TipKarte", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Tip");

                    b.HasKey("Id");

                    b.ToTable("TipoviKarte");
                });

            modelBuilder.Entity("eStanica.Data.Models.Transakcija", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("KarticaId");

                    b.Property<int>("KlijentId");

                    b.Property<int?>("KlijentiId");

                    b.Property<string>("Status");

                    b.Property<string>("brojTransakcije");

                    b.Property<DateTime>("datumKupovine");

                    b.Property<bool>("otkazano");

                    b.HasKey("Id");

                    b.HasIndex("KarticaId");

                    b.HasIndex("KlijentiId");

                    b.ToTable("Transakcije");
                });

            modelBuilder.Entity("eStanica.Data.Models.TransakcijaStavke", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("KartaId");

                    b.Property<int>("Kolicina");

                    b.Property<int?>("PopustId");

                    b.Property<int>("TransakcijaId");

                    b.Property<float>("UkupnaCijena");

                    b.HasKey("Id");

                    b.HasIndex("KartaId");

                    b.HasIndex("PopustId");

                    b.HasIndex("TransakcijaId");

                    b.ToTable("TransakcijaStavke");
                });

            modelBuilder.Entity("eStanica.Data.Models.Uloge", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv");

                    b.Property<string>("Opis");

                    b.HasKey("Id");

                    b.ToTable("Uloge");
                });

            modelBuilder.Entity("eStanica.Data.Models.Klijenti", b =>
                {
                    b.HasBaseType("eStanica.Data.Models.Korisnik");

                    b.Property<string>("BrojIndeksa");

                    b.Property<byte[]>("slikaIndeksa");

                    b.Property<byte[]>("slikaPenzionerskeKartice");

                    b.ToTable("Klijenti");

                    b.HasDiscriminator().HasValue("Klijenti");
                });

            modelBuilder.Entity("eStanica.Data.Models.Uposlenik", b =>
                {
                    b.HasBaseType("eStanica.Data.Models.Korisnik");

                    b.Property<int>("GodineIskustva");

                    b.ToTable("Uposlenik");

                    b.HasDiscriminator().HasValue("Uposlenik");
                });

            modelBuilder.Entity("eStanica.Data.Models.Grad", b =>
                {
                    b.HasOne("eStanica.Data.Models.Drzava", "Drzava")
                        .WithMany()
                        .HasForeignKey("DrzavaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("eStanica.Data.Models.Karta", b =>
                {
                    b.HasOne("eStanica.Data.Models.PosjecujeLokacije", "PosjecujeLokacije")
                        .WithMany()
                        .HasForeignKey("PosjecujeLokacijeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("eStanica.Data.Models.TipKarte", "TipKarte")
                        .WithMany()
                        .HasForeignKey("TipKarteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("eStanica.Data.Models.Kartica", b =>
                {
                    b.HasOne("eStanica.Data.Models.SredstvoPlacanja", "SredstvoPlacanja")
                        .WithMany()
                        .HasForeignKey("SredstvoPlacanjaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("eStanica.Data.Models.Korisnik", b =>
                {
                    b.HasOne("eStanica.Data.Models.Uloge", "Uloge")
                        .WithMany()
                        .HasForeignKey("UlogeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("eStanica.Data.Models.KretanjeAutobusa", b =>
                {
                    b.HasOne("eStanica.Data.Models.Autobus", "Autobus")
                        .WithMany()
                        .HasForeignKey("AutobusId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("eStanica.Data.Models.Linije", "Linije")
                        .WithMany()
                        .HasForeignKey("LinijeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("eStanica.Data.Models.Linije", b =>
                {
                    b.HasOne("eStanica.Data.Models.Grad", "Destinacija")
                        .WithMany()
                        .HasForeignKey("DestinacijaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("eStanica.Data.Models.Grad", "Polazak")
                        .WithMany()
                        .HasForeignKey("PolazakId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("eStanica.Data.Models.Prevoznik", "Prevoznik")
                        .WithMany()
                        .HasForeignKey("PrevoznikId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("eStanica.Data.Models.PosjecujeLokacije", b =>
                {
                    b.HasOne("eStanica.Data.Models.Grad", "Grad")
                        .WithMany()
                        .HasForeignKey("GradId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("eStanica.Data.Models.Linije", "Linije")
                        .WithMany()
                        .HasForeignKey("LinijeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("eStanica.Data.Models.PosjedujeAutobuse", b =>
                {
                    b.HasOne("eStanica.Data.Models.Autobus", "Autobus")
                        .WithMany()
                        .HasForeignKey("AutobusId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("eStanica.Data.Models.Prevoznik", "Prevoznik")
                        .WithMany()
                        .HasForeignKey("PrevoznikId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("eStanica.Data.Models.Recenzija", b =>
                {
                    b.HasOne("eStanica.Data.Models.Karta", "Karta")
                        .WithMany()
                        .HasForeignKey("KartaId");

                    b.HasOne("eStanica.Data.Models.Klijenti", "Klijenti")
                        .WithMany()
                        .HasForeignKey("KlijentiId");
                });

            modelBuilder.Entity("eStanica.Data.Models.SaobracajniDnevnik", b =>
                {
                    b.HasOne("eStanica.Data.Models.Stanica", "Stanica")
                        .WithMany()
                        .HasForeignKey("StanicaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("eStanica.Data.Models.Uposlenik", "Uposlenik")
                        .WithMany()
                        .HasForeignKey("UposlenikId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("eStanica.Data.Models.Stanica", b =>
                {
                    b.HasOne("eStanica.Data.Models.Grad", "Grad")
                        .WithMany()
                        .HasForeignKey("GradId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("eStanica.Data.Models.Transakcija", b =>
                {
                    b.HasOne("eStanica.Data.Models.Kartica", "Kartica")
                        .WithMany()
                        .HasForeignKey("KarticaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("eStanica.Data.Models.Klijenti", "Klijenti")
                        .WithMany()
                        .HasForeignKey("KlijentiId");
                });

            modelBuilder.Entity("eStanica.Data.Models.TransakcijaStavke", b =>
                {
                    b.HasOne("eStanica.Data.Models.Karta", "Karta")
                        .WithMany()
                        .HasForeignKey("KartaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("eStanica.Data.Models.Popust", "Popust")
                        .WithMany()
                        .HasForeignKey("PopustId");

                    b.HasOne("eStanica.Data.Models.Transakcija", "Transakcija")
                        .WithMany()
                        .HasForeignKey("TransakcijaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

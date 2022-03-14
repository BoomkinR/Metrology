﻿// <auto-generated />
using System;
using Metrology.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Metrology.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20220313134056_TransferLog")]
    partial class TransferLog
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("metrology")
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Metrology.Models.Contractor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<string>("ContactClient")
                        .HasColumnType("text")
                        .HasColumnName("CONTACT_CLIENT");

                    b.Property<string>("ContactNumper")
                        .HasColumnType("text")
                        .HasColumnName("CONTACT_NUMBER");

                    b.Property<string>("Inn")
                        .HasColumnType("text")
                        .HasColumnName("INN");

                    b.Property<string>("OrganisationName")
                        .HasColumnType("text")
                        .HasColumnName("ORGANISATION_NAME");

                    b.HasKey("ID");

                    b.ToTable("contractors", "metrology");
                });

            modelBuilder.Entity("Metrology.Models.Device", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateExplotationEnd")
                        .HasColumnType("TIMESTAMP(0)")
                        .HasColumnName("DATE_EXPLOTATION_END");

                    b.Property<DateTime>("DateExplotationStart")
                        .HasColumnType("TIMESTAMP(0)")
                        .HasColumnName("DATE_EXPLOTATION_START");

                    b.Property<DateTime>("DeviceDate")
                        .HasColumnType("TIMESTAMP(0)")
                        .HasColumnName("DEVICE_DATE");

                    b.Property<int?>("LocationID")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("NAME");

                    b.Property<int?>("OwnerUserID")
                        .HasColumnType("integer");

                    b.Property<string>("SerialNumber")
                        .HasColumnType("text")
                        .HasColumnName("SERIAL_NUMBER");

                    b.Property<int?>("StatusId")
                        .HasColumnType("integer");

                    b.Property<int>("TypeID")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("LocationID");

                    b.HasIndex("OwnerUserID");

                    b.HasIndex("StatusId");

                    b.HasIndex("TypeID");

                    b.ToTable("devices", "metrology");
                });

            modelBuilder.Entity("Metrology.Models.DeviceType", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("NAME");

                    b.HasKey("ID");

                    b.ToTable("device_type", "metrology");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "Измерительные"
                        });
                });

            modelBuilder.Entity("Metrology.Models.Location", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<int?>("LocationTypeId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("NAME");

                    b.Property<string>("Region")
                        .HasColumnType("text")
                        .HasColumnName("REGION");

                    b.HasKey("ID");

                    b.HasIndex("LocationTypeId");

                    b.ToTable("locations", "metrology");
                });

            modelBuilder.Entity("Metrology.Models.LocationType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("NAME");

                    b.HasKey("Id");

                    b.ToTable("location_type", "metrology");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "В Ремонте"
                        },
                        new
                        {
                            Id = 2,
                            Name = "ТСМ"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Куст"
                        });
                });

            modelBuilder.Entity("Metrology.Models.PresenceStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("ID");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("NAME");

                    b.HasKey("Id");

                    b.ToTable("presence_status", "metrology");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "В Наличие"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Передан"
                        });
                });

            modelBuilder.Entity("Metrology.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("ID");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("NAME");

                    b.Property<int>("Privelegies")
                        .HasColumnType("integer")
                        .HasColumnName("PREVILEGIES");

                    b.HasKey("Id");

                    b.ToTable("role", "metrology");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Администратор",
                            Privelegies = 7
                        },
                        new
                        {
                            Id = 2,
                            Name = "Главный Метролог",
                            Privelegies = 5
                        },
                        new
                        {
                            Id = 3,
                            Name = "Метролог",
                            Privelegies = 3
                        });
                });

            modelBuilder.Entity("Metrology.Models.TransferLog", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<bool>("Accepted")
                        .HasColumnType("boolean")
                        .HasColumnName("ACCEPTED");

                    b.Property<DateTime>("AcceptedDate")
                        .HasColumnType("TIMESTAMP(0)")
                        .HasColumnName("ACCEPTED_DATE");

                    b.Property<int?>("DeviceId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("TransferDate")
                        .HasColumnType("TIMESTAMP(0)")
                        .HasColumnName("TRANSFER_DATE");

                    b.Property<int?>("UserFromID")
                        .HasColumnType("integer");

                    b.Property<int?>("UserToID")
                        .HasColumnType("integer");

                    b.HasKey("ID");

                    b.HasIndex("DeviceId");

                    b.HasIndex("UserFromID");

                    b.HasIndex("UserToID");

                    b.ToTable("transfer_log", "metrology");
                });

            modelBuilder.Entity("Metrology.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("BirthDay")
                        .HasColumnType("TIMESTAMP(0)")
                        .HasColumnName("BIRTHDAY");

                    b.Property<string>("Email")
                        .HasColumnType("text")
                        .HasColumnName("EMAIL");

                    b.Property<string>("Login")
                        .HasColumnType("text")
                        .HasColumnName("LOGIN");

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("NAME");

                    b.Property<string>("Password")
                        .HasColumnType("text")
                        .HasColumnName("PASSWORD");

                    b.Property<string>("PatrName")
                        .HasColumnType("text")
                        .HasColumnName("PATRTNAME");

                    b.Property<string>("Phone")
                        .HasColumnType("text")
                        .HasColumnName("PHONE");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("TIMESTAMP(0)")
                        .HasColumnName("REGISTRATION_DATE");

                    b.Property<int?>("RoleId")
                        .HasColumnType("integer");

                    b.Property<string>("Surname")
                        .HasColumnType("text")
                        .HasColumnName("SURNAME");

                    b.HasKey("ID");

                    b.HasIndex("RoleId");

                    b.ToTable("users", "metrology");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            BirthDay = new DateTime(2022, 3, 13, 16, 40, 56, 157, DateTimeKind.Local).AddTicks(200),
                            Email = "admin@admin.ru",
                            Login = "admin",
                            Name = "Admin",
                            Password = "�iv�A���M�߱g��s�K��o*�H�",
                            PatrName = "Adminov",
                            Phone = "88888888888",
                            RegistrationDate = new DateTime(2022, 3, 13, 16, 40, 56, 157, DateTimeKind.Local).AddTicks(208),
                            Surname = "Adminovich"
                        });
                });

            modelBuilder.Entity("Metrology.Models.Device", b =>
                {
                    b.HasOne("Metrology.Models.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationID");

                    b.HasOne("Metrology.Models.User", "OwnerUser")
                        .WithMany()
                        .HasForeignKey("OwnerUserID");

                    b.HasOne("Metrology.Models.PresenceStatus", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId");

                    b.HasOne("Metrology.Models.DeviceType", "Type")
                        .WithMany()
                        .HasForeignKey("TypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");

                    b.Navigation("OwnerUser");

                    b.Navigation("Status");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("Metrology.Models.Location", b =>
                {
                    b.HasOne("Metrology.Models.LocationType", "LocationType")
                        .WithMany()
                        .HasForeignKey("LocationTypeId");

                    b.Navigation("LocationType");
                });

            modelBuilder.Entity("Metrology.Models.TransferLog", b =>
                {
                    b.HasOne("Metrology.Models.Device", "Device")
                        .WithMany()
                        .HasForeignKey("DeviceId");

                    b.HasOne("Metrology.Models.User", "UserFrom")
                        .WithMany()
                        .HasForeignKey("UserFromID");

                    b.HasOne("Metrology.Models.User", "UserTo")
                        .WithMany()
                        .HasForeignKey("UserToID");

                    b.Navigation("Device");

                    b.Navigation("UserFrom");

                    b.Navigation("UserTo");
                });

            modelBuilder.Entity("Metrology.Models.User", b =>
                {
                    b.HasOne("Metrology.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId");

                    b.Navigation("Role");
                });
#pragma warning restore 612, 618
        }
    }
}

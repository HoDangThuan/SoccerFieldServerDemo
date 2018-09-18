﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SoccerFieldServer.Infrastructure.Data;

namespace SoccerFieldServer.api.Migrations
{
    [DbContext(typeof(SoccerFieldServerContext))]
    [Migration("20180918041726_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("SoccerFieldServer.Core.Entities.AdminWebsite", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(6);

                    b.Property<string>("Name");

                    b.Property<string>("PassWord");

                    b.HasKey("Id");

                    b.ToTable("AdminWebsites");
                });

            modelBuilder.Entity("SoccerFieldServer.Core.Entities.BookField", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(12);

                    b.Property<string>("BillerId")
                        .IsRequired()
                        .HasMaxLength(12);

                    b.Property<decimal>("BookFieldFee");

                    b.Property<decimal>("ChangeFee");

                    b.Property<bool>("Condition");

                    b.Property<string>("CustomerId")
                        .IsRequired()
                        .HasMaxLength(12);

                    b.Property<DateTime>("DayOfActionBookField");

                    b.Property<DateTime>("DayOfBill");

                    b.Property<DateTime>("DayOfBookField");

                    b.Property<string>("Note");

                    b.Property<decimal>("ProductFee");

                    b.Property<string>("SoccerFieldId")
                        .IsRequired()
                        .HasMaxLength(12);

                    b.Property<string>("StaffId")
                        .IsRequired()
                        .HasMaxLength(12);

                    b.Property<DateTime>("TimeEnd");

                    b.Property<DateTime>("TimeStart");

                    b.Property<decimal>("TotalFee");

                    b.Property<decimal>("VatFee");

                    b.HasKey("Id");

                    b.HasIndex("BillerId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("SoccerFieldId");

                    b.HasIndex("StaffId");

                    b.ToTable("BookFields");
                });

            modelBuilder.Entity("SoccerFieldServer.Core.Entities.Customer", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(12);

                    b.Property<string>("Address");

                    b.Property<string>("BankAcount");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.Property<string>("PassWord");

                    b.Property<string>("PhoneNumber");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("SoccerFieldServer.Core.Entities.CustomerHistory", b =>
                {
                    b.Property<string>("CustomerId")
                        .HasMaxLength(12);

                    b.Property<string>("BookFieldId")
                        .HasMaxLength(12);

                    b.Property<string>("Note");

                    b.HasKey("CustomerId", "BookFieldId");

                    b.HasAlternateKey("BookFieldId", "CustomerId");

                    b.ToTable("CustomerHistorys");
                });

            modelBuilder.Entity("SoccerFieldServer.Core.Entities.DetailsOfBookField", b =>
                {
                    b.Property<string>("BookFieldId")
                        .HasMaxLength(12);

                    b.Property<string>("ProductId")
                        .HasMaxLength(12);

                    b.Property<int>("Amount");

                    b.Property<string>("BillerId")
                        .IsRequired()
                        .HasMaxLength(12);

                    b.Property<decimal>("Fee");

                    b.Property<decimal>("Price");

                    b.HasKey("BookFieldId", "ProductId");

                    b.HasIndex("BillerId");

                    b.HasIndex("ProductId");

                    b.ToTable("DetailsOfBookFields");
                });

            modelBuilder.Entity("SoccerFieldServer.Core.Entities.GroupSoccerField", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(6);

                    b.Property<string>("Address");

                    b.Property<DateTime>("CloseTime");

                    b.Property<bool>("Condition");

                    b.Property<string>("Name");

                    b.Property<string>("Note");

                    b.Property<DateTime>("OpenTime");

                    b.Property<double>("PercentPunish");

                    b.Property<double>("PercentRushHour");

                    b.Property<double>("PercentVAT");

                    b.HasKey("Id");

                    b.ToTable("GroupSoccerFields");
                });

            modelBuilder.Entity("SoccerFieldServer.Core.Entities.Product", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(12);

                    b.Property<int>("Amount");

                    b.Property<bool>("Condition");

                    b.Property<string>("GroupSoccerFieldId")
                        .IsRequired()
                        .HasMaxLength(6);

                    b.Property<string>("Name");

                    b.Property<string>("Note");

                    b.Property<decimal>("Price");

                    b.HasKey("Id");

                    b.HasIndex("GroupSoccerFieldId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("SoccerFieldServer.Core.Entities.SoccerField", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(12);

                    b.Property<bool>("Condition");

                    b.Property<string>("GroupSoccerFieldId")
                        .IsRequired()
                        .HasMaxLength(6);

                    b.Property<int>("Kind");

                    b.Property<string>("Note");

                    b.Property<decimal>("Price");

                    b.Property<int>("Size");

                    b.HasKey("Id");

                    b.HasIndex("GroupSoccerFieldId");

                    b.ToTable("SoccerFields");
                });

            modelBuilder.Entity("SoccerFieldServer.Core.Entities.Staff", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(12);

                    b.Property<string>("Address");

                    b.Property<string>("BankAcount");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("Email");

                    b.Property<string>("GroupSoccerFieldId")
                        .IsRequired()
                        .HasMaxLength(6);

                    b.Property<string>("Name");

                    b.Property<string>("PassWord");

                    b.Property<string>("PhoneNumber");

                    b.Property<string>("Regency");

                    b.HasKey("Id");

                    b.HasIndex("GroupSoccerFieldId");

                    b.ToTable("Staffs");
                });

            modelBuilder.Entity("SoccerFieldServer.Core.Entities.WorkScheduleStaff", b =>
                {
                    b.Property<string>("StaffId")
                        .HasMaxLength(12);

                    b.Property<DateTime>("Day");

                    b.Property<int>("Shift");

                    b.Property<bool>("Condition");

                    b.Property<string>("Note");

                    b.HasKey("StaffId", "Day", "Shift");

                    b.HasAlternateKey("Day", "Shift", "StaffId");

                    b.ToTable("WorkScheduleStaffs");
                });

            modelBuilder.Entity("SoccerFieldServer.Core.Entities.BookField", b =>
                {
                    b.HasOne("SoccerFieldServer.Core.Entities.Staff", "Biller")
                        .WithMany()
                        .HasForeignKey("BillerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SoccerFieldServer.Core.Entities.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SoccerFieldServer.Core.Entities.SoccerField", "SoccerField")
                        .WithMany()
                        .HasForeignKey("SoccerFieldId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SoccerFieldServer.Core.Entities.Staff", "Staff")
                        .WithMany()
                        .HasForeignKey("StaffId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SoccerFieldServer.Core.Entities.CustomerHistory", b =>
                {
                    b.HasOne("SoccerFieldServer.Core.Entities.BookField", "BookField")
                        .WithMany()
                        .HasForeignKey("BookFieldId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SoccerFieldServer.Core.Entities.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SoccerFieldServer.Core.Entities.DetailsOfBookField", b =>
                {
                    b.HasOne("SoccerFieldServer.Core.Entities.Staff", "Biller")
                        .WithMany()
                        .HasForeignKey("BillerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SoccerFieldServer.Core.Entities.BookField", "BookField")
                        .WithMany()
                        .HasForeignKey("BookFieldId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SoccerFieldServer.Core.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SoccerFieldServer.Core.Entities.Product", b =>
                {
                    b.HasOne("SoccerFieldServer.Core.Entities.GroupSoccerField", "GroupSoccerField")
                        .WithMany()
                        .HasForeignKey("GroupSoccerFieldId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SoccerFieldServer.Core.Entities.SoccerField", b =>
                {
                    b.HasOne("SoccerFieldServer.Core.Entities.GroupSoccerField", "GroupSoccerField")
                        .WithMany()
                        .HasForeignKey("GroupSoccerFieldId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SoccerFieldServer.Core.Entities.Staff", b =>
                {
                    b.HasOne("SoccerFieldServer.Core.Entities.GroupSoccerField", "GroupSoccerField")
                        .WithMany()
                        .HasForeignKey("GroupSoccerFieldId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SoccerFieldServer.Core.Entities.WorkScheduleStaff", b =>
                {
                    b.HasOne("SoccerFieldServer.Core.Entities.Staff", "Staff")
                        .WithMany()
                        .HasForeignKey("StaffId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

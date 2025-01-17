﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VKR_ServiceTransport.Ef.Persistance;

#nullable disable

namespace VKR_ServiceTransport.Ef.Migrations
{
    [DbContext(typeof(VKR_ServiceTransportContext))]
    [Migration("20240620163111_qwer")]
    partial class qwer
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.29");

            modelBuilder.Entity("VKR_ServiceTransport.Domain.Entities.Notice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("TEXT");

                    b.Property<DateOnly>("DateNotify")
                        .HasColumnType("TEXT");

                    b.Property<int>("MileageNotify")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("TransportId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("TransportId");

                    b.ToTable("Notices");
                });

            modelBuilder.Entity("VKR_ServiceTransport.Domain.Entities.Repair", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("CostSparePart")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("CostTotal")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("CostWork")
                        .HasColumnType("TEXT");

                    b.Property<int>("CurrentMileage")
                        .HasColumnType("INTEGER");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("TEXT");

                    b.Property<int>("PartNumbers")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("TransportId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("WhatWasDone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("TransportId");

                    b.ToTable("Repairs");
                });

            modelBuilder.Entity("VKR_ServiceTransport.Domain.Entities.SparePartsIntervals", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("IntervalByDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("IntervalByMileage")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("TransportId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("TransportId");

                    b.ToTable("SparePartsIntervals");
                });

            modelBuilder.Entity("VKR_ServiceTransport.Domain.Entities.Transport", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Mileage")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("StateNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("VIN")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Transports");
                });

            modelBuilder.Entity("VKR_ServiceTransport.Domain.Entities.Notice", b =>
                {
                    b.HasOne("VKR_ServiceTransport.Domain.Entities.Transport", null)
                        .WithMany("Notices")
                        .HasForeignKey("TransportId");
                });

            modelBuilder.Entity("VKR_ServiceTransport.Domain.Entities.Repair", b =>
                {
                    b.HasOne("VKR_ServiceTransport.Domain.Entities.Transport", null)
                        .WithMany("Repairs")
                        .HasForeignKey("TransportId");
                });

            modelBuilder.Entity("VKR_ServiceTransport.Domain.Entities.SparePartsIntervals", b =>
                {
                    b.HasOne("VKR_ServiceTransport.Domain.Entities.Transport", null)
                        .WithMany("SparePartsIntervals")
                        .HasForeignKey("TransportId");
                });

            modelBuilder.Entity("VKR_ServiceTransport.Domain.Entities.Transport", b =>
                {
                    b.Navigation("Notices");

                    b.Navigation("Repairs");

                    b.Navigation("SparePartsIntervals");
                });
#pragma warning restore 612, 618
        }
    }
}

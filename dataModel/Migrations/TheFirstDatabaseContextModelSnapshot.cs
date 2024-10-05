﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using dataModel;

#nullable disable

namespace dataModel.Migrations
{
    [DbContext(typeof(TheFirstDatabaseContext))]
    partial class TheFirstDatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("dataModel.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool?>("Capital")
                        .HasColumnType("bit")
                        .HasColumnName("capital");

                    b.Property<int>("CountryId")
                        .HasColumnType("int")
                        .HasColumnName("countryId");

                    b.Property<double>("Latitude")
                        .HasColumnType("float")
                        .HasColumnName("latitude");

                    b.Property<double>("Longitude")
                        .HasColumnType("float")
                        .HasColumnName("longitude");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("name")
                        .IsFixedLength();

                    b.Property<long>("Population")
                        .HasColumnType("bigint")
                        .HasColumnName("population");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("dataModel.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Iso2")
                        .IsRequired()
                        .HasMaxLength(2)
                        .IsUnicode(false)
                        .HasColumnType("char(2)")
                        .HasColumnName("iso2")
                        .IsFixedLength();

                    b.Property<string>("Iso3")
                        .IsRequired()
                        .HasMaxLength(3)
                        .IsUnicode(false)
                        .HasColumnType("char(3)")
                        .HasColumnName("iso3")
                        .IsFixedLength();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("Country");
                });

            modelBuilder.Entity("dataModel.City", b =>
                {
                    b.HasOne("dataModel.Country", "Country")
                        .WithMany("Cities")
                        .HasForeignKey("CountryId")
                        .IsRequired()
                        .HasConstraintName("FK_Cities_Country");

                    b.Navigation("Country");
                });

            modelBuilder.Entity("dataModel.Country", b =>
                {
                    b.Navigation("Cities");
                });
#pragma warning restore 612, 618
        }
    }
}

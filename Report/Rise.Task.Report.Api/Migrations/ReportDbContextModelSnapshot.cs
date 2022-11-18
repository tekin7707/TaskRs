﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Rise.Task.Report.Api.Db;

#nullable disable

namespace Rise.Task.Report.Api.Migrations
{
    [DbContext(typeof(ReportDbContext))]
    partial class ReportDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Rise.Task.Report.Api.Domain.ReportModel", b =>
                {
                    b.Property<int>("UUID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("UUID"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("FilePath")
                        .HasColumnType("text");

                    b.Property<bool>("IsReady")
                        .HasColumnType("boolean");

                    b.HasKey("UUID");

                    b.ToTable("Reports", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}

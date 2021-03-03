﻿// <auto-generated />
using System;
using BlazorApp1.Job;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlazorApp1.Migrations
{
    [DbContext(typeof(TodoContext))]
    [Migration("20210303025255_createjob")]
    partial class createjob
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BlazorApp1.Job.Job", b =>
                {
                    b.Property<DateTime?>("Endtime")
                        .HasColumnType("datetime")
                        .HasColumnName("endtime");

                    b.Property<int>("IdJob")
                        .HasColumnType("int")
                        .HasColumnName("id_Job");

                    b.Property<string>("Namejob")
                        .HasMaxLength(1)
                        .HasColumnType("nvarchar(1)")
                        .HasColumnName("namejob");

                    b.Property<DateTime?>("Starttime")
                        .HasColumnType("datetime")
                        .HasColumnName("starttime");

                    b.Property<string>("Status")
                        .HasMaxLength(1)
                        .HasColumnType("nvarchar(1)")
                        .HasColumnName("status");

                    b.ToTable("Job");
                });
#pragma warning restore 612, 618
        }
    }
}
﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ThiGK_30_11.Models;

namespace ThiGK_30_11.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20191130030717_DBInit")]
    partial class DBInit
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ThiGK_30_11.Models.NhanVien", b =>
                {
                    b.Property<int>("MaNV")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("Luong");

                    b.Property<int?>("MaPB");

                    b.Property<string>("TenNV")
                        .IsRequired()
                        .HasColumnName("nvarchar(100)");

                    b.HasKey("MaNV");

                    b.HasIndex("MaPB");

                    b.ToTable("NhanViens");
                });

            modelBuilder.Entity("ThiGK_30_11.Models.PhongBan", b =>
                {
                    b.Property<int>("MaPB")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TenPB")
                        .IsRequired()
                        .HasColumnName("nvarchar(100)");

                    b.HasKey("MaPB");

                    b.ToTable("PhongBans");
                });

            modelBuilder.Entity("ThiGK_30_11.Models.NhanVien", b =>
                {
                    b.HasOne("ThiGK_30_11.Models.PhongBan", "phongban")
                        .WithMany()
                        .HasForeignKey("MaPB");
                });
#pragma warning restore 612, 618
        }
    }
}

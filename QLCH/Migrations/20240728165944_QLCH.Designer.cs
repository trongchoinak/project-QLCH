
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QLCH.Data;

#nullable disable

namespace QLCH.Migrations
{
    [DbContext(typeof(QLCHDbConText))]
    [Migration("20240728165944_QLCH")]
    partial class QLCH
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("QLCH.Models.Ban", b =>
                {
                    b.Property<int>("BanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BanId"));

                    b.Property<int>("SoBan")
                        .HasColumnType("int");

                    b.HasKey("BanId");

                    b.ToTable("Bans");
                });

            modelBuilder.Entity("QLCH.Models.ChiTietDonHang", b =>
                {
                    b.Property<int>("CTDHId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CTDHId"));

                    b.Property<int>("DonHangId")
                        .HasColumnType("int");

                    b.Property<int>("Gia")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgayTao")
                        .HasColumnType("datetime2");

                    b.Property<int>("SanPhamId")
                        .HasColumnType("int");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.HasKey("CTDHId");

                    b.HasIndex("DonHangId");

                    b.HasIndex("SanPhamId");

                    b.ToTable("ChiTietDonHangs");
                });

            modelBuilder.Entity("QLCH.Models.Client", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Pass")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("UserId");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("QLCH.Models.DanhMuc", b =>
                {
                    b.Property<int>("DanhMucId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DanhMucId"));

                    b.Property<string>("MoTa")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("TenDanhMuc")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("DanhMucId");

                    b.ToTable("DanhMucs");
                });

            modelBuilder.Entity("QLCH.Models.DonHang", b =>
                {
                    b.Property<int>("DonHangId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DonHangId"));

                    b.Property<DateTime>("NgayDatHang")
                        .HasColumnType("datetime2");

                    b.Property<int>("TongTien")
                        .HasColumnType("int");

                    b.Property<string>("TrangThai")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("DonHangId");

                    b.HasIndex("UserId");

                    b.ToTable("DonHangs");
                });

            modelBuilder.Entity("QLCH.Models.QR", b =>
                {
                    b.Property<int>("QRId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("QRId"));

                    b.Property<int>("BanId")
                        .HasColumnType("int");

                    b.Property<string>("DuLieuMaQR")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("QRId");

                    b.HasIndex("BanId");

                    b.ToTable("QRs");
                });

            modelBuilder.Entity("QLCH.Models.SanPham", b =>
                {
                    b.Property<int>("SanPhamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SanPhamId"));

                    b.Property<int>("DanhMucId")
                        .HasColumnType("int");

                    b.Property<int>("Gia")
                        .HasColumnType("int");

                    b.Property<string>("MoTa")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("SanPhamId");

                    b.HasIndex("DanhMucId");

                    b.ToTable("SanPhams");
                });

            modelBuilder.Entity("QLCH.Models.ThanhToan", b =>
                {
                    b.Property<int>("ThanhToanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ThanhToanId"));

                    b.Property<int>("DonHangId")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgayThanhToan")
                        .HasColumnType("datetime2");

                    b.Property<string>("PhuongThucThanhToan")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<int>("SoTien")
                        .HasColumnType("int");

                    b.Property<string>("TrangThai")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("ThanhToanId");

                    b.HasIndex("DonHangId");

                    b.ToTable("ThanhToans");
                });

            modelBuilder.Entity("QLCH.Models.store", b =>
                {
                    b.Property<int>("StoreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StoreId"));

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Pass")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("QuocGia")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Sdt")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("StoreId");

                    b.ToTable("Stores");
                });

            modelBuilder.Entity("QLCH.Models.ChiTietDonHang", b =>
                {
                    b.HasOne("QLCH.Models.DonHang", "DonHang")
                        .WithMany("ChiTietDonHangs")
                        .HasForeignKey("DonHangId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QLCH.Models.SanPham", "SanPham")
                        .WithMany()
                        .HasForeignKey("SanPhamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DonHang");

                    b.Navigation("SanPham");
                });

            modelBuilder.Entity("QLCH.Models.DonHang", b =>
                {
                    b.HasOne("QLCH.Models.Client", "Client")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("QLCH.Models.QR", b =>
                {
                    b.HasOne("QLCH.Models.Ban", "Ban")
                        .WithMany()
                        .HasForeignKey("BanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ban");
                });

            modelBuilder.Entity("QLCH.Models.SanPham", b =>
                {
                    b.HasOne("QLCH.Models.DanhMuc", "DanhMuc")
                        .WithMany("SanPhams")
                        .HasForeignKey("DanhMucId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DanhMuc");
                });

            modelBuilder.Entity("QLCH.Models.ThanhToan", b =>
                {
                    b.HasOne("QLCH.Models.DonHang", "DonHang")
                        .WithMany("ThanhToans")
                        .HasForeignKey("DonHangId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DonHang");
                });

            modelBuilder.Entity("QLCH.Models.DanhMuc", b =>
                {
                    b.Navigation("SanPhams");
                });

            modelBuilder.Entity("QLCH.Models.DonHang", b =>
                {
                    b.Navigation("ChiTietDonHangs");

                    b.Navigation("ThanhToans");
                });
#pragma warning restore 612, 618
        }
    }
}

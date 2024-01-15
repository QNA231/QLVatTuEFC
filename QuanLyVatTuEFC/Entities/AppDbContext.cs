using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVatTuEFC.Entities
{
    public class AppDbContext : DbContext
    {
        public virtual DbSet<VatTu> VatTu { get; set; }
        public virtual DbSet<PhieuNhap> PhieuNhap { get; set; }
        public virtual DbSet<ChiTietPhieuNhap> ChiTietPhieuNhap { get; set; }
        public virtual DbSet<PhieuXuat> PhieuXuat { get; set; }
        public virtual DbSet<ChiTietPhieuXuat> ChiTietPhieuXuat { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer($"Server = LAPTOP-1600EKM7\\SQLEXPRESS; Database = QLVatTu; Trusted_Connection = True; TrustServerCertificate = True");
        }
    }
}

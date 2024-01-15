using QuanLyVatTuEFC.Entities;
using QuanLyVatTuEFC.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVatTuEFC.Services
{
    public class PhieuNhapServices : IPhieuNhapServices
    {
        private readonly AppDbContext dbContext;

        public PhieuNhapServices()
        {
            this.dbContext = new AppDbContext();
        }

        public void ThemPhieuNhap(PhieuNhap nhap)
        {
            nhap.NhapThongTIn();
            dbContext.Add(nhap);
            dbContext.SaveChanges();
            Console.WriteLine("Them phieu nhap thanh cong!");
        }
    }
}

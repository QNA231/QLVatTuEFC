using QuanLyVatTuEFC.Entities;
using QuanLyVatTuEFC.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVatTuEFC.Services
{
    public class PhieuXuatServices : IPhieuXuatServices
    {
        private readonly AppDbContext dbContext;

        public PhieuXuatServices()
        {
            this.dbContext = new AppDbContext();
        }

        public void ThemPhieuXuat(PhieuXuat xuat)
        {
            xuat.NhapThongTIn();
            dbContext.Add(xuat);
            dbContext.SaveChanges();
            Console.WriteLine("Them phieu xuat thanh cong");
        }
    }
}

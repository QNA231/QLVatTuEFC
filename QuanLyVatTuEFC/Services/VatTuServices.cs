using QuanLyVatTuEFC.Entities;
using QuanLyVatTuEFC.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVatTuEFC.Services
{
    public class VatTuServices : IVatTuServices
    {
        private readonly AppDbContext dbContext;

        public VatTuServices()
        {
            this.dbContext = new AppDbContext();
        }

        public void HienThiVatTuCanNhap()
        {
            var result = dbContext.VatTu.Select(x => new { x.TenVatTu, x.SoLuongTon });
            foreach (var item in result)
            {
                if (item.SoLuongTon == 0)
                {
                    Console.WriteLine($"Ten vat tu: {item.TenVatTu}\n");
                }
            }
        }

        public void HienThiVatTuHienCo()
        {
            var result = dbContext.VatTu.Select(x => new { x.TenVatTu, x.SoLuongTon });
            foreach(var item in result)
            {
                if(item.SoLuongTon == 0)
                {
                    Console.WriteLine($"Ten vat tu: {item.TenVatTu} \nSo luong ton: Het hang\n");
                }
                else
                {
                    Console.WriteLine($"Ten vat tu: {item.TenVatTu} \nSo luong ton: {item.SoLuongTon}\n");
                }
            }
        }

        public void ThemVatTu(VatTu vt)
        {
            vt.NhapThongTIn();
            dbContext.Add(vt);
            dbContext.SaveChanges();
            Console.WriteLine("Them vat tu thanh cong!");
        }
    }
}

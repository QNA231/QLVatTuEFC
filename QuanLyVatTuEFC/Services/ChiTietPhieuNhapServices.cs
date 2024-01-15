using QuanLyVatTuEFC.Entities;
using QuanLyVatTuEFC.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVatTuEFC.Services
{
    public class ChiTietPhieuNhapServices : IChiTietPhieuNhapServices
    {
        private readonly AppDbContext dbContext;

        public ChiTietPhieuNhapServices()
        {
            this.dbContext = new AppDbContext();
        }

        public void ThemChiTietPhieuNhap(int nhapId, int vtId)
        {
            PhieuNhap phieuNhap = dbContext.PhieuNhap.FirstOrDefault(x => x.PhieuNhapId == nhapId);
            VatTu vatTu = dbContext.VatTu.FirstOrDefault(x => x.VatTuId == vtId);
            ChiTietPhieuNhap ch = new ChiTietPhieuNhap();
            if (phieuNhap != null && vatTu != null) 
            {
                ch.NhapThongTin(vtId, nhapId);
                dbContext.Add(ch);
                dbContext.SaveChanges();

                vatTu.SoLuongTon += ch.SoLuongNhap;
                dbContext.Update(vatTu);
                dbContext.SaveChanges();
                Console.WriteLine("Them chi tiet phieu nhap thanh cong!");
            }
        }
    }
}

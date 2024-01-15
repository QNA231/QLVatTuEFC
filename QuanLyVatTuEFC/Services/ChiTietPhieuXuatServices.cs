using QuanLyVatTuEFC.Entities;
using QuanLyVatTuEFC.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVatTuEFC.Services
{
    public class ChiTietPhieuXuatServices : IChiTietPhieuXuatServices
    {
        private readonly AppDbContext dbContext;

        public ChiTietPhieuXuatServices()
        {
            this.dbContext = new AppDbContext();
        }

        public void ThemChiTietPhieuXuat(int xuatId, int vtId)
        {
            PhieuXuat phieuXuat = dbContext.PhieuXuat.FirstOrDefault(x => x.PhieuXuatId == xuatId);
            VatTu vatTu = dbContext.VatTu.FirstOrDefault(x => x.VatTuId == vtId);
            ChiTietPhieuXuat ch = new ChiTietPhieuXuat();
            if (phieuXuat != null && vatTu != null)
            {
                ch.NhapThongTin(vtId, xuatId);
                if(ch.SoLuongXuat > vatTu.SoLuongTon)
                {
                    Console.WriteLine("Trong kho khong du so luong!");
                }
                else
                {
                    dbContext.Add(ch);
                    dbContext.SaveChanges();
                    vatTu.SoLuongTon -= ch.SoLuongXuat;
                    dbContext.Update(vatTu);
                    dbContext.SaveChanges();
                    Console.WriteLine("Them chi tiet phieu nhap thanh cong!");
                }
            }
        }
    }
}

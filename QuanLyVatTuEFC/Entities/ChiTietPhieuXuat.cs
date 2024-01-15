using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVatTuEFC.Entities
{
    public class ChiTietPhieuXuat
    {
        public int ChiTietPhieuXuatId { get; set; }
        public int VatTuId { get; set; }
        public int PhieuXuatId { get; set; }
        public int SoLuongXuat { get; set; }
        public VatTu VatTu { get; set; }
        public PhieuXuat PhieuNhapXuat { get; set; }
        public void NhapThongTin(int vtID, int pnID)
        {
            ChiTietPhieuXuatId = 0;
            VatTuId = vtID;
            PhieuXuatId = pnID;
            Console.WriteLine("Nhap so luong xuat: ");
            SoLuongXuat = int.Parse(Console.ReadLine());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVatTuEFC.Entities
{
    public class ChiTietPhieuNhap
    {
        public int ChiTietPhieuNhapId { get; set; }
        public int VatTuId { get; set; }
        public int PhieuNhapId { get; set; }
        public int SoLuongNhap { get; set; }
        public VatTu VatTu { get; set; }
        public PhieuNhap PhieuNhap { get; set; }
        public void NhapThongTin(int vtID, int pnID)
        {
            ChiTietPhieuNhapId = 0;
            VatTuId = vtID;
            PhieuNhapId = pnID;
            Console.WriteLine("Nhap so luong nhap: ");
            SoLuongNhap = int.Parse(Console.ReadLine());
        }
    }
}

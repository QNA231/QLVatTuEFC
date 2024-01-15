using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVatTuEFC.Entities
{
    public class PhieuXuat
    {
        public int PhieuXuatId { get; set; }
        public string MaPhieu { get; set; }
        public string TieuDe { get; set; }
        public DateTime NgayXuat { get; set; }
        public void NhapThongTIn()
        {
            PhieuXuatId = 0;
            Console.WriteLine("Nhap ma phieu: ");
            MaPhieu = Console.ReadLine();
            Console.WriteLine("Nhap tieu de: ");
            TieuDe = Console.ReadLine();
            Console.WriteLine("Nhap ngay xuat: ");
            NgayXuat = DateTime.Parse(Console.ReadLine());
        }
    }
}

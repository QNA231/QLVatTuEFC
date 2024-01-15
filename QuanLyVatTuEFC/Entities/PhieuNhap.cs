using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVatTuEFC.Entities
{
    public class PhieuNhap
    {
        public int PhieuNhapId { get; set; }
        public string MaPhieu { get; set; }
        public string TieuDe { get; set; }
        public DateTime NgayNhap { get; set; }
        public void NhapThongTIn()
        {
            PhieuNhapId = 0;
            Console.WriteLine("Nhap ma phieu: ");
            MaPhieu = Console.ReadLine();
            Console.WriteLine("Nhap tieu de: ");
            TieuDe = Console.ReadLine();
            Console.WriteLine("Nhap ngay nhap: ");
            NgayNhap = DateTime.Parse(Console.ReadLine());
        }
    }
}

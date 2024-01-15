using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVatTuEFC.Entities
{
    public class VatTu
    {
        public int VatTuId { get; set; }
        public string TenVatTu { get; set; }
        public int SoLuongTon { get; set; }
        public void NhapThongTIn()
        {
            VatTuId = 0;
            Console.WriteLine("Nhap ten vat tu: ");
            TenVatTu = Console.ReadLine();
            Console.WriteLine("Nhap so luong ton: ");
            SoLuongTon = int.Parse(Console.ReadLine());
        }
    }
}

using QuanLyVatTuEFC.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVatTuEFC.IServices
{
    public interface IVatTuServices
    {
        void ThemVatTu(VatTu vt);
        void HienThiVatTuHienCo();
        void HienThiVatTuCanNhap();
    }
}

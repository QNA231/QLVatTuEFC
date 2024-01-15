using QuanLyVatTuEFC.Entities;
using QuanLyVatTuEFC.IServices;
using QuanLyVatTuEFC.Services;

static void Main()
{
    Console.InputEncoding = System.Text.Encoding.UTF8;
    Console.OutputEncoding = System.Text.Encoding.UTF8;
    IVatTuServices vatTuServices = new VatTuServices();
    IPhieuNhapServices phieuNhapServices = new PhieuNhapServices();
    IChiTietPhieuNhapServices chiTietPhieuNhapServices = new ChiTietPhieuNhapServices();
    IPhieuXuatServices phieuXuatServices = new PhieuXuatServices();
    IChiTietPhieuXuatServices chiTietPhieuXuatServices = new ChiTietPhieuXuatServices();

    Console.WriteLine("------------Quan ly vat tu------------");
    Console.WriteLine("1. Them vat tu");
    Console.WriteLine("2. Them phieu nhap");
    Console.WriteLine("3. Them chi tiet phieu nhap");
    Console.WriteLine("4. Them phieu xuat");
    Console.WriteLine("5. Them chi tiet phieu xuat");
    Console.WriteLine("6. Hien thi danh sach vat tu hien co trong kho");
    Console.WriteLine("7. Hien thi danh sach vat tu can them");
    Console.WriteLine("----------------------------------------");
    Console.WriteLine("Chon: ");
    string s = Console.ReadLine();
    switch (s)
    {
        case "1":
            VatTu vt = new VatTu();
            vatTuServices.ThemVatTu(vt);
            break;
        case "2":
            PhieuNhap pn = new PhieuNhap();
            phieuNhapServices.ThemPhieuNhap(pn);
            break;
        case "3":
            Console.WriteLine("Nhap Id phieu nhap can them chi tiet: ");
            int pnID = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap Id vat tu duoc them vao chi tiet phieu nhap: ");
            int vtID = int.Parse(Console.ReadLine()); 
            chiTietPhieuNhapServices.ThemChiTietPhieuNhap(pnID, vtID);
            break;
        case "4":
            PhieuXuat px = new PhieuXuat();
            phieuXuatServices.ThemPhieuXuat(px);
            break;
        case "5":
            Console.WriteLine("Nhap Id phieu xuat can them chi tiet: ");
            int pnId = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap Id vat tu duoc them vao chi tiet phieu xuat: ");
            int vtId = int.Parse(Console.ReadLine());
            chiTietPhieuXuatServices.ThemChiTietPhieuXuat(pnId, vtId);
            break;
        case "6":
            vatTuServices.HienThiVatTuHienCo();
            break;
        case "7":
            vatTuServices.HienThiVatTuCanNhap();
            break;
    }
}
Main();
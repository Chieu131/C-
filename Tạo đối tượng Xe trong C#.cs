using System;

public class Xe
{
    public string MauXe { get; set; }
    public string HangSanXuat { get; set; }
    public string BienSo { get; set; }
    public int TocDo { get; private set; }

    public Xe(string mauXe, string hangSanXuat, string bienSo)
    {
        MauXe = mauXe;
        HangSanXuat = hangSanXuat;
        BienSo = bienSo;
        TocDo = 0;
    }

    public void TangToc(int giaTri)
    {
        TocDo += giaTri;
        Console.WriteLine($"Tăng tốc: Tốc độ hiện tại là {TocDo} km/h");
    }

    public void GiamToc(int giaTri)
    {
        TocDo -= giaTri;
        if (TocDo < 0)
        {
            TocDo = 0;
        }
        Console.WriteLine($"Giảm tốc: Tốc độ hiện tại là {TocDo} km/h");
    }

    public void ThongTinXe()
    {
        Console.WriteLine($"Màu xe: {MauXe}, Hãng sản xuất: {HangSanXuat}, Biển số: {BienSo}, Tốc độ: {TocDo} km/h");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Xe xe1 = new Xe("Đỏ", "Toyota", "79A-12345");
        Xe xe2 = new Xe("Xanh", "Honda", "29B-54321");
        Xe xe3 = new Xe("Trắng", "Ford", "30C-67890");

        xe1.TangToc(20);
        xe1.GiamToc(5);
        xe1.ThongTinXe();

        xe2.TangToc(50);
        xe2.GiamToc(30);
        xe2.ThongTinXe();

        xe3.TangToc(80);
        xe3.GiamToc(60);
        xe3.ThongTinXe();
    }
}

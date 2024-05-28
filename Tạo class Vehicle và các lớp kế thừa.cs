using System;

public class Vehicle
{
    public string MauXe { get; set; }
    public string HangSanXuat { get; set; }
    public string BienSo { get; set; }
    public int TocDo { get; protected set; }

    public Vehicle(string mauXe, string hangSanXuat, string bienSo)
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

public class XeTo : Vehicle
{
    public XeTo(string mauXe, string hangSanXuat, string bienSo)
        : base(mauXe, hangSanXuat, bienSo)
    {
    }
}

public class XeMay : Vehicle
{
    public XeMay(string mauXe, string hangSanXuat, string bienSo)
        : base(mauXe, hangSanXuat, bienSo)
    {
    }
}

public class MayBay : Vehicle
{
    public MayBay(string mauXe, string hangSanXuat, string bienSo)
        : base(mauXe, hangSanXuat, bienSo)
    {
    }

    public void CatCanh()
    {
        Console.WriteLine("Máy bay cất cánh!");
    }

    public void HaCanh()
    {
        Console.WriteLine("Máy bay hạ cánh!");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        XeTo xeTo = new XeTo("Đỏ", "Toyota", "79A-12345");
        XeMay xeMay = new XeMay("Xanh", "Honda", "29B-54321");
        MayBay mayBay = new MayBay("Trắng", "Boeing", "VN-67890");

        xeTo.TangToc(20);
        xeTo.GiamToc(5);
        xeTo.ThongTinXe();

        xeMay.TangToc(50);
        xeMay.GiamToc(30);
        xeMay.ThongTinXe();

        mayBay.TangToc(300);
        mayBay.GiamToc(100);
        mayBay.ThongTinXe();
        mayBay.CatCanh();
        mayBay.HaCanh();
    }
}

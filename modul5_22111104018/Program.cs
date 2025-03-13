using System;

public class Penjumlahan
{
    public T JumlahTigaAngka<T>(T angka1, T angka2, T angka3)
    {
        dynamic temp1 = angka1;
        dynamic temp2 = angka2;
        dynamic temp3 = angka3;
        return temp1 + temp2 + temp3;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Penjumlahan penjumlahan = new Penjumlahan();
        int hasil = penjumlahan.JumlahTigaAngka(22, 11, 18);
        Console.WriteLine($"Hasil penjumlahan: {hasil}");
    }
}

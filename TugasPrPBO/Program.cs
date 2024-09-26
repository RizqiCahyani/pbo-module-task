using System;

class Program
{
    static void Main(string[] args)
    {
        KebunBinatang kebunBinatang = new KebunBinatang();

        Singa singa = new Singa { Nama = "Leon", Umur = 5, JumlahKaki = 4 };
        Gajah gajah = new Gajah { Nama = "Phan", Umur = 10, JumlahKaki = 4 };
        Ular ular = new Ular { Nama = "Piton", Umur = 3, PanjangTubuh = 4.5 };
        Buaya buaya = new Buaya { Nama = "Boy", Umur = 7, PanjangTubuh = 2.0 };

        kebunBinatang.TambahHewan(singa);
        kebunBinatang.TambahHewan(gajah);
        kebunBinatang.TambahHewan(ular);
        kebunBinatang.TambahHewan(buaya);

        kebunBinatang.DaftarHewan();

        Hewan[] hewanArray = { singa, gajah, ular, buaya };
        foreach (var hewan in hewanArray)
        {
            Console.WriteLine($"{hewan.Nama} bersuara: {hewan.Suara()}");
        }

        Console.WriteLine(singa.Mengaum());
        Console.WriteLine(ular.Merayap());

        // Jawaban pertanyaan analisis
        // Soal 1:
        Console.WriteLine($"Gajah: {gajah.Suara()}");
        Console.WriteLine($"Ular: {ular.Suara()}");

        // Soal 2: 
        Console.WriteLine(singa.Mengaum());

        // Soal 3: 
        Console.WriteLine(singa.InfoHewan());

        // Soal 4:
        Console.WriteLine(ular.Merayap());

        // Soal 5: 
        Reptil reptil = new Buaya { Nama = "Bay", Umur = 6, PanjangTubuh = 2.8 };
        Console.WriteLine($"Suara: {reptil.Suara()}");
    }
}

public class Hewan
{
    public string Nama { get; set; }
    public int Umur { get; set; }

    public virtual string Suara()
    {
        return "Hewan ini bersuara";
    }

    public virtual string InfoHewan()
    {
        return $"Nama: {Nama}, Umur: {Umur} tahun";
    }
}

public class Mamalia : Hewan
{
    public int JumlahKaki { get; set; }

    public override string InfoHewan()
    {
        return base.InfoHewan() + $", Jumlah Kaki: {JumlahKaki}";
    }
}

public class Reptil : Hewan
{
    public double PanjangTubuh { get; set; }

    public override string InfoHewan()
    {
        return base.InfoHewan() + $", Panjang Tubuh: {PanjangTubuh} meter";
    }
}

public class Singa : Mamalia
{
    public override string Suara()
    {
        return "Roarrr!";
    }

    public string Mengaum()
    {
        return "Singa mengaum dengan sangat keras!";
    }
}

public class Gajah : Mamalia
{
    public override string Suara()
    {
        return "Toooottttt!";
    }
}

public class Ular : Reptil
{
    public override string Suara()
    {
        return "Suuussssssttttt!";
    }

    public string Merayap()
    {
        return "Ular merayap dengan gesit!";
    }
}

public class Buaya : Reptil
{
    public override string Suara()
    {
        return "kiww kiww cewekk";
    }
}

public class KebunBinatang
{
    private List<Hewan> koleksiHewan = new List<Hewan>();

    public void TambahHewan(Hewan hewan)
    {
        koleksiHewan.Add(hewan);
    }

    public void DaftarHewan()
    {
        Console.WriteLine("Daftar Hewan di Kebun Binatang:");
        foreach (var hewan in koleksiHewan)
        {
            Console.WriteLine(hewan.InfoHewan());
        }
    }
}

using System;

class Kasir : User
{
    //Constructor
    public Kasir(String nama) : base(nama) { }
    //Overriding
    public override void TampilkanInfo()
    {
        Console.WriteLine($"\nKasir: {Nama}");
    }
}
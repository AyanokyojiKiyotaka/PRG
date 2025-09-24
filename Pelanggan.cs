using System;

//Inheritance
class Pelanggan : User
{
    //Constructor
    public Pelanggan(string nama) : base(nama) { }
    //Overloading
    public void Pesanan(Menu menu)
    {
         //Encapsulation
        if (menu.StokTersedia)
        {
            menu.StokTersedia = false;
            Console.WriteLine($"{Nama} memesan {menu.NamaMenu}");
        }
        else
        {
            Console.WriteLine($"{menu.NamaMenu} sudah habis");
        }
    }
    //Overloading
    public void Pesanan(Menu menu1, Menu menu2)
    {
        Pesanan(menu1);
        Pesanan(menu2);
    }
    //Overriding
    public override void TampilkanInfo()
    {
        Console.WriteLine($"Pelanggan: {Nama}");
    }
}
using System;
class Menu
{
    private string namaMenu;
    public int Harga { get; set; }
    public bool Stok { get; set; }

    public Menu(String nama, int harga)
    {
        this.namaMenu = nama;
        this.Harga = harga;
        this.Stok = true;
    }
    public string NamaMenu
    {
        get { return namaMenu; }
    }
    public void Info()
    {
        Console.WriteLine($"Menu: {namaMenu}, Harga: Rp{Harga}, Status: {(Stok ? "Tersedia" : "Habis")}");
    }
}
using System;

class Restoran
{
    public Menu[] DaftarMenu;
    public User[] DaftarUser;

    //Constructor
    public Restoran(Menu[] menu, User[] user)
    {
        //Composition
        DaftarMenu = menu;
        DaftarUser = user;
    }
    public void TampilkanMenu()
    {
        Console.WriteLine("\n-----Menu Restoran----");
        foreach (var m in DaftarMenu) m.Info();
    }
    public void TampilkanUser()
    {
        Console.WriteLine("\n--- Daftar User ---");
        //Polymorphism
        foreach (var u in DaftarUser) u.TampilkanInfo();
    }
}
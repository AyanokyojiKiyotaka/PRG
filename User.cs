using System;

class User
{
    public string Nama { get; set; }
    public User(string nama)
    {
        Nama = nama;
    }
    public virtual void TampilkanInfo()
    {
        Console.WriteLine($"User: {Nama}");
    }
}
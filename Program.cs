// See https://aka.ms/new-console-template for more information
using System;

namespace MyFirstApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Menu[] menu = {
            new Menu("Nasi Goreng", 20000),
            new Menu("Mie Ayam", 15000),
            new Menu("Es Teh", 5000)
        };
        //Inheritance
        User[] user = {
            new Pelanggan("Upil"),
            new Kasir("Ipil")
        };
        //Composition
        Restoran resto = new Restoran(menu, user);

        resto.TampilkanMenu();
        resto.TampilkanUser();

        Pelanggan p = (Pelanggan)user[0];
        p.Pesanan(menu[0]);           
        p.Pesanan(menu[1], menu[2]);  

        resto.TampilkanMenu();


            Console.Write("Tekan tombol apapun untuk keluar...");
            Console.ReadKey();
        }
    }
}
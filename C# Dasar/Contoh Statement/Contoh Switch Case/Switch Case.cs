﻿using System;

class main
{
    static void Main(string[] args)
    {
        int pilihan;

        Console.WriteLine("Menu :\n");
        Console.WriteLine("1. Contoh Ke Satu");
        Console.WriteLine("2. Contoh Ke Dua");
        Console.WriteLine("3. Contoh Ke Tiga");
        Console.WriteLine("4. Contoh Ke Empat");
        Console.Write("Masukan Pilihan : ");
        pilihan = int.Parse(Console.ReadLine());

        switch (pilihan)
        {
            case 1:
                Console.WriteLine("Contoh Ke-1 Berhasil Dicoba");
                break;
            case 2:
                Console.WriteLine("Contoh Ke-2 Berhasil Dicoba");
                break;
            case 3:
                Console.WriteLine("Contoh Ke-3 Berhasil Dicoba");
                break;
            case 4:
                Console.WriteLine("Contoh Ke-4 Berhasil Dicoba");
                break;
            default:
                Console.WriteLine("Masukkan Pilihan Dengan Benar");
                break;
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
namespace sequentialSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Memasukkan Jumlah angka
            Stopwatch timerr = new Stopwatch();
            int[] a = new int[10000000];
            Console.WriteLine("Masukkan Batas Angka :");
            string s = Console.ReadLine();
            int x = int.Parse(s);

            //List angka
            Console.WriteLine("==============");
            Console.WriteLine("List Angka ");
            Console.WriteLine("==============");

            //Proses Pengkonvertan Elemen Array agar bisa dibaca program
            for (int i = 0; i < x; i++)
            {
                a[i] = i + 1;
                Console.WriteLine(a[i]);
            }

            Console.WriteLine("=========================");
            Console.WriteLine("Masukan Angka yang dicari");
            Console.WriteLine("=========================");

            //Proses Pendeklarasian Nilai terkecil dan terbesar
            string s3 = Console.ReadLine();
            int x2 = int.Parse(s3);

            //proses pencarian
            timerr.Start();
            for (int i = 0; i < x; i++)
            {
                 if (a[i] == x2)
                 {
                    Console.WriteLine("==================");
                    Console.WriteLine("Pencarian Berhasil");
                    Console.WriteLine("==================");
                    Console.WriteLine("Angka {0} ditemukan \n", x2, i + 1);
                    Console.WriteLine("waktu yang di butuhkan untuk mencari angka : " + timerr.Elapsed);
                    timerr.Stop();
                    Console.ReadLine();
                    return;

                }
            }
            timerr.Stop();
            Console.WriteLine("Pencarian Gagal, angka tidak ditemukan");
            Console.WriteLine("waktu yang di butuhkan untuk mencari angka : " + timerr.Elapsed);
            Console.ReadLine();
        }


    }
}




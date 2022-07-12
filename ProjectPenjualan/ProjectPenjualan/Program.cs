using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPenjualan
{
    public class Program
    {
        static List<Penjualan> daftarPenjualan = new List<Penjualan>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();
                Console.Write("\nNomor Menu [1..3]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahPenjualan();
                        break;

                    case 2:
                        TampilPenjualan();
                        break;

                    case 3:
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            Console.WriteLine("Pilih Menu Aplikasi");
            Console.WriteLine();
            Console.WriteLine("1. Tambah Penjualan");
            Console.WriteLine("2. Tampilkan Penjualan");
            Console.WriteLine("3. Keluar");
        }

        static void TambahPenjualan()
        {
            Console.Clear();
            Console.WriteLine("Tambah Data Penjualan");
            Penjualan jual = new Penjualan();

            Console.WriteLine();

            Console.Write("Nota : ");
            jual.Nota = Console.ReadLine();

            Console.Write("Tanggal : ");
            jual.Tanggal = Console.ReadLine();

            Console.Write("Customer : ");
            jual.Customer = Console.ReadLine();

            Console.Write("Jenis [T/K] : ");
            jual.Jenis = Console.ReadLine();

            Console.Write("Total Nota : ");
            jual.Total_Nota = Convert.ToInt32(Console.ReadLine());

            daftarPenjualan.Add(jual);

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilPenjualan()
        {
            Console.Clear();
            Console.WriteLine("Data Penjualan");
            Console.WriteLine();

            for (int i=0; i < daftarPenjualan.Count; i++)
            {
                Penjualan jual = daftarPenjualan[i];
                if (jual.Jenis == "T")
                {
                    jual.Jenis = "Tunai";
                }
                else
                {
                    jual.Jenis = "Kredit";
                }
                
                Console.Write(i + 1);
                Console.WriteLine(". {0}, {1}, {2}, {3}, {4}", jual.Nota, jual.Tanggal, jual.Customer, jual.Jenis, jual.Total_Nota);
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
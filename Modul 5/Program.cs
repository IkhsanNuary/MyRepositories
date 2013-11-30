using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Latihan_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nilai = new int[0];
            int ganjil = 0;
            int genap = 0;
            int positif = 0;
            int negatif = 0;
            float rata = 0;
            ConsoleKeyInfo ulang;
            do
            {
                Array.Resize(ref nilai, nilai.Length + 1);
                Console.Write("Input Sembarang Angka= ");
                nilai[nilai.GetUpperBound(0)] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Mau Input Data Lagi? (Y/T)= ");
                ulang = Console.ReadKey();
                Console.WriteLine("\n");
            } while (ulang.KeyChar == 'y' || ulang.KeyChar == 'Y');

            Console.WriteLine("\nBarisan Angka: ");
            Array.Sort(nilai);
            foreach (int i in nilai)
                Console.Write("{0} ", i);
         
            foreach (int i in nilai)
                if (i % 2 == 1 || i % 2 == -1)
                    ganjil += 1;
            Console.WriteLine("\nJumlah Bilangan Ganjil = {0}", ganjil);
           
            foreach (int i in nilai)
                if (i != 0)
                    if (i % 2 == 0)
                        genap += 1;
            Console.WriteLine("Jumlah Bilangan Genap = {0}", genap);

            foreach (int i in nilai)
                if (i > 0)
                    positif += 1;
            Console.WriteLine("Jumlah Bilangan Positif = {0}", positif);

            foreach (int i in nilai)
                if (i < 0)
                    negatif += 1;
            Console.WriteLine("Jumlah Bilangan Negatif = {0}", negatif);
            
            Console.WriteLine("Nilai Minimum = {0}", nilai[0]);

            Array.Reverse(nilai);
            Console.WriteLine("Nilai Maksimum = {0}", nilai[0]);

            foreach (int i in nilai)
                rata += i;
            Console.WriteLine("Rata-rata = {0}", rata / nilai.Length);
            
            Console.ReadKey();
        }
    }
}

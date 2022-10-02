using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_2_1214056
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selamat Datang!");
            Console.Write("Masukan Gaji Anda : ");

            int gajipokok = int.Parse(Console.ReadLine());
            int tunjangan = (gajipokok * 20) / 100;
            int bonus = (gajipokok * 15) / 100;
            double pph = (gajipokok * 3.5) / 100;
            double total = (gajipokok + tunjangan + bonus);
            double bersih = (gajipokok + tunjangan + bonus)- pph;

            Console.WriteLine("Gaji Pokok = " + gajipokok);
            Console.WriteLine("Tunjangan = " + tunjangan);
            Console.WriteLine("Bonus = " + bonus);
            Console.WriteLine("PPH = " + pph);
            Console.WriteLine("Total Gaji = " + total);
            Console.WriteLine("Gaji Bersih = " + bersih);
        }
    }
}

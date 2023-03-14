using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsoleApp
{
    class program
    {
        static void main(string[] args)
        {
            Console.Title = "aplikasi calculator";

            int a = 10; // declarasi variable a, dg nilai awal 10;
            int b = 6; // declarasi variable b, dg nilai awal 6;

            Console.WriteLine("imputkan nilai a = ");
            a = int.Parse(Console.ReadLine());//proses casting

            Console.WriteLine("imputkan nilai a = ");
            b = int.Parse(Console.ReadLine());//proses casting

            Console.WriteLine();// tambahkan baris kosong

            Console.Writeline("hasil penambahan " + a + "+" + b + "=" + penamabahan(a, b));
            Console.Writeline("hasil pengurangan {0} - {1} = {2}" a, b, pengurangan(a, b));
            Console.Writeline("hasil perkalian {0} * {1} = {2}" a, b, perkalian(a, b));
            Console.Writeline("hasil pembagian {0} / {1} = {2}" a, b, pembagian(a, b));

            Console.Writeline("\nTekan sembarang key untuk keluar");
            Console.ReadKey;
        }
        static int penambahan(imt a, int b)
        {
            return a + b;
        }
        static internal pengurangan(int a, int b)
        {
            return a - b;
        }
        static int perkalian(imt a, int b)
        {
            return a * b;
        }
        static int pembagian(imt a, int b)
        {
            return a / b;
        }

    }
}
  
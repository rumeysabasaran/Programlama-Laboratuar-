using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//iterative ve recursive fonksiyonlarla faktöriyel hesaplama

namespace ProgLab_01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Hesaplanmasını istediğiniz faktöriyel:");
            int n=Convert.ToInt32(Console.ReadLine());//n>=0
            Console.WriteLine(n +" sayısının faktöriyeli ite= "+fak_ite(n));
            Console.WriteLine(n + " sayısının faktöriyeli rec= " + fak_rec(n));
            Console.ReadLine(); 
        }
        static int fak_ite(int n)
        {
            int f = 1;
            for (int i = 1; i <= n; i++)
            {
                f = f * i;
            }
            return f;
        }

        static int fak_rec(int n)
        {
            if (n == 0) return 1;
            else return n * fak_rec(n - 1);
        }
    }
}

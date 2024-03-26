using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ÜS ALMA FONKSİYONU 

namespace ProgLab_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("üs alınacak sayıyı giriniz");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("üssünü giriniz");
            int b=Convert.ToInt32(Console.ReadLine());  
            Console.WriteLine(a + "üssü"+ b + "= " + us_alma(a,b));
            Console.ReadLine();
        }
        static int us_alma(int a , int b)
        {
            int sonuc = 1;
            if (a == 0 | b == 0)
                Console.WriteLine("Sonuç belirsiz");
            else if (b == 0)
                Console.WriteLine("Sonuç 1");
            for (int i = 1;i <= b; i++) {
                sonuc = sonuc * a;
            }
            return sonuc;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
    static void Main(string[] args)
    {
        Calculator();
    }

    static void Calculator(){
        
        Console.WriteLine("Enter C (Celsius): ");
        string C = Console.ReadLine();
        Console.WriteLine("Enter Km/h (Wind Speed): ");
        string km = Console.ReadLine();

        double C_convert = Convert.ToDouble(C);
        double Km_convert = Convert.ToDouble(km);

        double Calc = 13.12 + 0.6215 * C_convert - 11.37 * (System.Math.Pow(Km_convert, 0.16)) + 0.3965 * C_convert * (System.Math.Pow(Km_convert, 0.16));
        // 13,12 + 0,6215 * T - 11,37 * (v^0,16)+ 0,3965 * T * (v^0,16) = WCT
        Console.WriteLine("WindChill-Temperatur ist: {0:F2}",Calc);
    }

    }
}

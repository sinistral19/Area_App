using System;
using Area_Lib;

namespace Area_App
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double[] x = { 10 };
            Lib_App.Area_Circle(x);

            double[] y = { 20, 40, 50 };

            double area = Lib_App.Area_Triangle(y);

            Console.ReadLine();
        }
    }
}

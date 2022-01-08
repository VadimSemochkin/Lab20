using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab20
{
    class Program
    {
        delegate  double MyDelegate(double R);
        static void Main(string[] args)
        {
            Console.Write("Введите радиус окружности:");
            double r = Convert.ToDouble(Console.ReadLine());
            MyDelegate myDelegate = new MyDelegate(Lenth);
            myDelegate += Square;
            myDelegate += Volume;
            myDelegate?.Invoke(r);
            Console.ReadKey();

        }

        static double Lenth(double R)
        {
            double D = 2 * R * Math.PI;
            Console.WriteLine($"Длинна окружности равна {D}");
            return D;
        }
        static double Square(double R)
        {
            double S = R * R * Math.PI;
            Console.WriteLine($"Площадь круга равна {S}");
            return S;
        }
        static double Volume(double R)
        {
            double V = (4/3)*Math.Pow(R,3)*Math.PI;
            Console.WriteLine($"Объем шара равен {V}");
            return V;
        }
    }
}

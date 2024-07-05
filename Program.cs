using System;
using System.Globalization;
using exeRetanguloClass;
namespace exeRetanguloClass
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Retangulo x, y;
            x = new Retangulo();
            
            
            
            Console.WriteLine("Escreva a largura e altura do retangulo: ");
            x.L = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);

            double areax = x.Area();
            Console.WriteLine("Area :" + areax.ToString("F2", CultureInfo.InvariantCulture));

            double perimetrox = x.Perimetro();
            Console.WriteLine("Perímetro: " + perimetrox.ToString("F2", CultureInfo.InvariantCulture));

            double diagonalx = x.Diagonal();
            Console.WriteLine("Diagonal: " + diagonalx.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
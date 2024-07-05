using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exeRetanguloClass
{
     class Retangulo
    {
        public double L;
        public double A;




        public double Area()
        {
            double area = (L * A);
            return area;
        }

        public double Perimetro()
        {
            double perimetro = (L + A) + (L + A);
            return perimetro;
        }
        public double Diagonal()
        {
            double d = Math.Pow(L, 2) + Math.Pow(A, 2);
            double diagonal = (Math.Sqrt(d));
            return diagonal;
        }
    }
}
using System;

namespace AtividadeParaNota
{
    class Program
    {
        static void Main(string[] args)
        {

            EquacaoSegundoGrau();
        }

        static double AreaCirculo(int raio)
        {
            double area = 0;
            double pi = 3.1416;

            //pi * raio ^2
            area = pi * Math.Pow(raio, 2);
            return area;
        }

        static int CalcularFatorial(int n)
        {
            int fat = n;
            while (n > 1)
            {
                fat *= (n - 1);//3*2*1
                n--;
            }
            return fat;

        }
]
       static void EquacaoSegundoGrau()
        {
            double a, b, c, delta, x1, x2;

            a =3 ;
            b = 56;
            c = 8;
            delta = Math.Pow(b,2) - 4 * a * c;

            if (a == 0.0 || delta < 0.0)
            {
                Console.WriteLine("IMPOSSIVEL CALCULAR");
            }
            else
            {
                x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);
                Console.WriteLine("X1 = " + x1.ToString("F4"));
                Console.WriteLine("X2 = " + x2.ToString("F4"));
            }

        }
    }
}

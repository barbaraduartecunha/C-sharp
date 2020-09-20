using System;
using System.Globalization;

namespace calculo_area_retangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criar as variaveis
            double b, a, area, perimetro, diagonal;
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //atribuir os calculos as variaveis
            area = a * b;
            perimetro = 2 * b + 2 * a;
            diagonal = Math.Sqrt(Math.Pow(b, 2.0) + Math.Pow(a, 2.0));

            //Mostrar calculos na tela
            Console.WriteLine("AREA = " + area.ToString("F4",CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = " + perimetro.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + diagonal.ToString("F4", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}

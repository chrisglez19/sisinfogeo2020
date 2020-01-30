using System;

namespace _03.areatriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double bas, altura, area;
            Console.WriteLine("Programa que calcula el area de un triangulo");

            Console.WriteLine("Dame la base : ");
            bas= double.Parse(Console.ReadLine());
            Console.WriteLine("Dame la altura: ");
            altura= double.Parse(Console.ReadLine());

            area = (bas * altura)/2;

            Console.WriteLine($"El area del triangulo es {area}");
            Console.ReadLine();
        }
    }
}

using System;
using System.Linq;

namespace _21.Linq1
{
    class Program
    {
        static void Main(string[] args)
        {

            //fuente de datos
            int[] numeros = new int [] {
                10,20,30,40,50,60,70,80,90,100,
                -10,-20,0,1000,2000,3000,4000,5000,
                10,20,30,40,50,60,70,80,90,101,
                -10,-20,0,1000,2000,3000,4000,5000
            };

            //Consulta 1, paraes, regresa un IENUMERABLE<int>
            var consulta =
                from num in numeros
                where num%2==0
                select num;

            //Ejecutr consulta
            foreach (var num in consulta)
                Console.Write($"{num} ");
            
            //Consulta 2, numeroes entre 10 y 200, ni ceros en un arreglo regresa un int[]
            var consulta2 = 
                (from num in numeros 
                where num>=10 && num<=200 
                select num).ToArray();

            Console.WriteLine();

            Console.WriteLine("\nNumeros mayores a 100\n");
            for (int i=0; i<consulta2.Count(); i++)
                Console.WriteLine($"{consulta2[i]} ");

            //Consulta 3, negativvos en una lista
            var consulta3 =
                (from num in numeros
                where num>0
                select  num).ToList();

            Console.WriteLine("\nNumeros negativvos:\n");
            consulta3.ForEach(num=>Console.WriteLine(num));
        }
    }
}

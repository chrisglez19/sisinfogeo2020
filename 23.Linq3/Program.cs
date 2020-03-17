using System;
using System.Collections.Generic;
using System.Linq;

namespace _23.Linq3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Estudiante> grupo =  new List<Estudiante>();

            grupo.Add( 
                new Estudiante {Id=1234,Nombre="Jose",
                Ciudad="Zacatecas", Calle = "1A de Mayo",
                Cals=  new List<int> {90,80,70,60}});

            grupo.Add( 
                new Estudiante {Id=3421,Nombre="Maria",
                Ciudad="Fresnillo", Calle = "Benito",
                Cals=  new List<int> {90,80,70,60}});

            grupo.Add( 
                new Estudiante {Id=2222,Nombre="Miguel",
                Ciudad="Jerez", Calle = "Garcia Salinaz",
                Cals=  new List<int> {50,50,50,40}});

            grupo.Add( 
                new Estudiante {Id=6666,Nombre="Lourdes",
                Ciudad="Zacatecas", Calle = "El Vergel",
                Cals=  new List<int> {100,100,100,90}});   

            //Imprime los datos
            Console.WriteLine("\nTodo de todo\n");
            grupo.ForEach(Estudiante=>Console.WriteLine(Estudiante.ToString())); 

            var q1 = ( 
                from est in grupo
                orderby est.Nombre
                select est).ToList();
            
            Console.WriteLine("\nTodo ordenado por nombre: \n");
            q1.ForEach(est=>Console.WriteLine(est.ToString()));

            //Nadamas los de zacatecas
            var q2 = ( 
                from est in grupo
                where est.Ciudad=="Zacatecas"
                select est).ToList();
            
            Console.WriteLine("\nNadamas los de Zac:\n");
            q2.ForEach(est=>Console.WriteLine(est.ToString()));

            //Estudiantes promedio mayor a 70
            var q3 = ( 
                from est in grupo
                where est.Cals.Average()>70
                select new {nombre=est.Nombre, promedio=est.Cals.Average() }
                ).ToList();
            
            Console.WriteLine("\nNombre y promedio de los mayores a 70 \n");
            q3.ForEach(est=>Console.WriteLine($"Nombre:{est.nombre}, Promedio:{est.promedio}"));

            //Agrupar por ciudad
            var q4 = 
                from est in grupo
                group est by est.Ciudad;
                
            Console.WriteLine("\nTodo ordenado por nombre: \n");
            foreach(var ciudad in q4){
                Console.WriteLine(ciudad.Key);
                foreach(var est in ciudad)
                Console.WriteLine(est.ToString());
            }
        }
    }
}

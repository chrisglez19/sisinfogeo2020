using System;
using System.Collections.Generic;

namespace _20.Listasv2
{
    class Program
    {
        static void Main(string[] args)
        {
           List<Pieza> mp= new List<Pieza>();

           mp.Add(new Pieza(1234, "Tuerca de rosca interior"));
           mp.Add(new Pieza(5678, "Tornillo cabeza grande"));
           mp.Add(new Pieza(9345, "Bateria 12v"));
           
            var proveedor = new List<Pieza>() {
                new Pieza(8888,"Tornillo cabeza pequenia"),
                new Pieza(9999,"Tornillo cabeza pequenia"),
                new Pieza(6666,"Tridente del diablo")                
            };
        mp.AddRange(proveedor);

        //Usar el metodo foreach itegrado en la lista para imprimir su contenido

        mp.ForEach(p=>Console.WriteLine(p.ToString()));
    
        //Eliminar un elemento de la lista
        mp.RemoveAt(mp.Count-1);

        //Insertar un elemento en la posicion 2
        Console.WriteLine("Insertar un elemento en la posicion 2");
        mp.Insert(1, new Pieza(2222,"caja de 8 velocidades"));
        mp.ForEach(p=>Console.WriteLine(p.ToString()));

        //Buscar todas las piezas que tengan la palabra tornillo
        Console.WriteLine("Piezas que contienen tornillo");
        var t=mp.FindAll(x=>x.Nombre.Contains("Tornillo"));
        t.ForEach(p=>Console.WriteLine(p.ToString()));      
        
        //Buscar todas las piezas cuyo ID es menor a 5000
        Console.WriteLine("Piezas con id>5000");
        var t1=mp.FindAll(x=>x.Id>5000);
        t1.ForEach(p=>Console.WriteLine(p.ToString()));
        
        }
    }
}

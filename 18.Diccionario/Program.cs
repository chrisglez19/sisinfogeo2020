using System;
using System.Collections.Generic;

namespace _18.Diccionario
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Dictionary<string, string> midic = new Dictionary<string, string>();

            SortedDictionary<string, string> midic = new SortedDictionary<string, string>();

            midic.Add("txt","archivo de texto");
            midic.Add("jpg","archivo de imagen");
            midic.Add("mp3","archivo de sonido");
            midic.Add("htm","archivo de HTML");
            midic.Add("exe","archivo ejecutable windows");
            midic.Add("lll","archivo de tipo desconocido");

            //Acceder a un elemento en base a la llave
            Console.WriteLine(midic["htm"]);

            // Verificar si una llave existe, si no, agregarla
            if(midic.ContainsKey("elf"))
                Console.WriteLine("La llave ya existe");
            else
                midic.Add("elf","Archivo ejecutable LINUX");

            //Borrar una entrada si la llave existe
           if(midic.ContainsKey("lll"))
                midic.Remove("lll");

            //Modificar un valor del diccionario en base a la llave
            midic["htm"]="Archivo de texto HTML";

            //Recorrer el diccionario e iprimir la llave y su valor
            foreach(KeyValuePair<string, string> val in midic) 
                Console.WriteLine($"{val.Key} - {val.Value}");

            //Imprimir solo las llaves del diccionario
            foreach(string llave in midic.Keys)
                Console.WriteLine(llave);

            //Imprimir solo los valores del diccionario
            foreach(string valor in midic.Values)
                Console.WriteLine(valor);

            //Borrar todas las entradas del diicionario
            midic.Clear();

           
        }
    }
}

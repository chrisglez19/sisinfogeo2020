using System;

namespace _1.Parcial1
{
    class Program
    {
        static void Inicializa(Red red){
            red.AgregarNodo(new Nodo("192.168.0.11","Servidor","80","10","Linux"));
            red.AgregarNodo(new Nodo("192.168.0.13","equipoactivo","80","10","Linux"));
            red.AgregarNodo(new Nodo("192.168.0.20","computadora","8230","8","Windows"));
            red.AgregarNodo(new Nodo("192.168.0.30","computadora","8230","7","Linux"));
            red.AgregarNodo(new Nodo("192.168.0.40","computadora","8230","6","Otro"));
            
            

            red.Nodos[0].AgregarVulnerabilidad(new Vulnerabilidad("1000","Edubijes Juarez","Se puede acceder desde cualquer disp","remota","14/junio/2019"));
            red.Nodos[1].AgregarVulnerabilidad(new Vulnerabilidad("2000","Irasema Lopez","Se puede acceder desde cualquer disp","remota","11/mayo/2019"));
            red.Nodos[1].AgregarVulnerabilidad(new Vulnerabilidad("3000","Jhon Pen","Se muestran los correos y quedan acceso a todos","local","11/abril/2019"));
            red.Nodos[3].AgregarVulnerabilidad(new Vulnerabilidad("4000","Juan Penas","La direccion ip esta expuesta","remota","4/enero/2020"));
            red.Nodos[4].AgregarVulnerabilidad(new Vulnerabilidad("5000","Eraclito Mijares","Se puede acceder desde cualquer disp","local","24/febrero/2020"));            
            red.Nodos[4].AgregarVulnerabilidad(new Vulnerabilidad("6000","Ernesto Cuevas","Se puede acceder desde cualquer disp","remota","17/enro/2020"));
            
            
        }
        static void Reporte(Red red){
            Console.Clear();
            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"{red.Empresa}");
            Console.WriteLine("Reporte de Red");
            Console.WriteLine("----------------------------------------");
            foreach(Nodo ndo in red.Nodos){
                Console.WriteLine($"{ndo.Ip}");
                Console.WriteLine($"Total de Vulnerabilidades: {ndo.Vulnerabilidades.Count}\n");
            }
            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"Total Nodos: {red.Nodos.Count}");
        }
            
        static void Main()
        {
            Red miRed = new Red("Red Chingona", "Christian Gonzalez", "5 de Mayo Calera Zac.");
            Inicializa(miRed);    
            Reporte(miRed);
        }

    }
}

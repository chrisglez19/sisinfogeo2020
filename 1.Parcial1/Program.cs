using System;

namespace _1.Parcial1
{
    class Program
    {
        static void Inicializa(Red red){
            red.AgregarNodo(new Nodo("192.168.0.11","Servidor","80",12,"Linux"));
            red.AgregarNodo(new Nodo("192.168.0.13","equipoactivo","80",10,"Linux"));
            red.AgregarNodo(new Nodo("192.168.0.20","computadora","8230",8,"Windows"));
            red.AgregarNodo(new Nodo("192.168.0.30","computadora","8230",7,"Linux"));
            red.AgregarNodo(new Nodo("192.168.0.40","computadora","8230",6,"Otro"));
            
            

            red.Nodos[0].AgregarVulnerabilidad(new Vulnerabilidad("C-1000","Edubijes Juarez","Se puede acceder desde cualquer disp","remota",DateTime.Parse("14/6/2017")));
            red.Nodos[1].AgregarVulnerabilidad(new Vulnerabilidad("C-2000","Irasema Lopez","Se puede acceder desde cualquer disp","remota",DateTime.Parse("11/5/2017")));
            red.Nodos[1].AgregarVulnerabilidad(new Vulnerabilidad("C-3000","Jhon Pen","Se muestran los correos y quedan acceso a todos","local",DateTime.Parse("11/4/2018")));
            red.Nodos[3].AgregarVulnerabilidad(new Vulnerabilidad("C-4000","Juan Penas","La direccion ip esta expuesta","remota",DateTime.Parse("4/1/2016")));
            red.Nodos[4].AgregarVulnerabilidad(new Vulnerabilidad("C-5000","Eraclito Mijares","Se puede acceder desde cualquer disp","local",DateTime.Parse("24/2/2015")));            
            red.Nodos[4].AgregarVulnerabilidad(new Vulnerabilidad("C-6000","Ernesto Cuevas","Se puede acceder desde cualquer disp","remota",DateTime.Parse("17/1/2015")));
            
            
        }
        static void Reporte(Red red){
            DateTime fechaHoy = DateTime.Now;
            int mayor=0;
            int menor=1000;
            int i=0;
            Console.Clear();
            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"Empresa: {red.Empresa}");
            Console.WriteLine($"Propietario: {red.Propietario}");
            Console.WriteLine($"Domicilio: {red.Domicilio}");
            Console.WriteLine("         Reporte de Red");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Total Nodos: {red.Nodos.Count}");
            foreach(Nodo ndo in red.Nodos){
                if(ndo.Saltos>=mayor)
                    mayor=ndo.Saltos;
                if(ndo.Saltos<=menor)
                    menor=ndo.Saltos;
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine($"Ip:{ndo.Ip}");
                Console.WriteLine($"Tipo: {ndo.Tipo}");
                Console.WriteLine($"Puertos:{ndo.Puertos}");
                Console.WriteLine($"Saltos: {ndo.Saltos}");
                Console.WriteLine($"Sistema Operativo: {ndo.So}");
                Console.WriteLine("             -----------------------");
                Console.WriteLine($"Total de Vulnerabilidades: {ndo.Vulnerabilidades.Count}\n");
                foreach(Vulnerabilidad vul in ndo.Vulnerabilidades){
                    TimeSpan ts = fechaHoy-vul.Fecha;
                    int difDias = ts.Days;
                    int aniosAntiguedad = difDias/365;
                    Console.WriteLine($"Clave: {vul.Clave}\nVendedor: {vul.Vendedor}\nDescripcion: {vul.Descripcion}\nTipo: {vul.Tipo}\nFecha: {vul.Fecha}");
                    Console.WriteLine($"Antiguedad: {aniosAntiguedad}\n");
                    i+=1;
                   
                }
            }
            Console.WriteLine($"El mayor numero de saltos es: {mayor}");
            Console.WriteLine($"El menor numero de saltos es: {menor}");
           
        }
            
        static void Main()
        {
            Red miRed = new Red("Red Chingona", "Christian Gonzalez", "5 de Mayo Calera Zac.");
            Inicializa(miRed);    
            Reporte(miRed);
        }

    }
}

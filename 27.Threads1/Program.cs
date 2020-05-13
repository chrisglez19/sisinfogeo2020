using System;
using System.Threading;

namespace _27.Threads1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nombrando Hilo principal
            Thread.CurrentThread.Name="Principal";

            //Creacion de 2 Hilos
            Thread t1 = new Thread(Imprime);
            Thread t2 = new Thread(Imprime);

            //Nombramos los hilos
            t1.Name="Hilo1";
            t2.Name="Hilo2";
            //Invocamos los threads
            t1.Start();
            t2.Start();

            //Invocacion de Imprime desde el Hilo principal
            Imprime();

            Console.WriteLine("Saludos desde Main, ha terminado todo");
        }

        static void Imprime(){
            for (int i=0; i<10; i++){
                Console.WriteLine($"Imprime . {i} desde {Thread.CurrentThread.Name}");
                Thread.Sleep(100);
            }
        }
    }
}

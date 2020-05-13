using System;
using System.Threading;

namespace _30.Threads4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hilo principal iniciado");
            //Crear y asignar nombre al hilo
            Thread t1 =new Thread(Metodo1){Name = "Cliente1"};
            Thread t2 =new Thread(Metodo2){Name = "Cliente2"};
            Thread t3 =new Thread(Metodo3){Name = "Cliente3"};

            //Ejecucion de metodos
            t1.Start();
            t2.Start();
            t3.Start();
            Console.WriteLine("Thread principal Terminado");
        }

        static void Metodo1()
        {
            Console.WriteLine("Metodo 1 iniciado usando " + Thread.CurrentThread.Name);
            for (int i=1; i<=5; i++)
                Console.WriteLine("Metodo 1: "+i);
            Console.WriteLine("Metodo 1 finalizado usando " + Thread.CurrentThread.Name);
        }

        static void Metodo2()
        {
            Console.WriteLine("Metodo 2 iniciado usando " + Thread.CurrentThread.Name);
            for (int i=1; i<=5; i++)
            {
                Console.WriteLine("Metodo 2: "+i);
                if(i==3)
                {
                    Console.WriteLine("Iniciando operacion sobre la DB ");
                    Thread.Sleep(10000);
                    Console.WriteLine("Operacion sobre la DB finalizada");
                }
            }
            Console.WriteLine("Metodo 2 finalizado usando " + Thread.CurrentThread.Name);
        }

        static void Metodo3()
        {
            Console.WriteLine("Metodo3 iniciado usando " + Thread.CurrentThread.Name);
            for (int i=1; i<=5; i++)
                Console.WriteLine("Metodo 3: "+i);
            Console.WriteLine("Metodo 3 finalizado usando " + Thread.CurrentThread.Name);
        }



    }
}

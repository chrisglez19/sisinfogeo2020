using System;

namespace _06.tablas
{
    class Program
    {
        static int Main(string[] args)
        {
            int op, nTabla=0, inicio=0, fin=0,mult, total=0,i=0;
            if (args.Length==0) {
            Menu();
            return 1;
            }

            op= int.Parse(args[0]);
            nTabla = int.Parse(args[1]);
            inicio = int.Parse(args[2]);
            fin = int.Parse(args[3]);

            Console.Clear();
            switch (op)
            {
                case 1: { 
                    Console.WriteLine($"\nTabla del {nTabla} del {inicio} al {fin}");
                   while (inicio<=fin){
                        mult= nTabla * inicio;
                        Console.Write($"{nTabla}x{inicio}={mult}\n");
                        inicio++;
                   }
                } break;
                 case 2: { 
                    Console.WriteLine($"Tabla desde el 1 hasta el {nTabla} del {inicio} al {fin}");
                    
                   while(total<=nTabla) {
                       i=inicio;
                       total++;
                    Console.Write($"Tabla del {total}\n\n");
                        while (i<=fin){
                            mult= total * i;
                            Console.Write($"{total}x{i}={mult}\n");
                            i++;
                        }
                    
                   }
                } break;
                default:Console.WriteLine("Opcion Invalida");break;
            }
            return 0;
        }
          static void Menu() {
            Console.Clear();
            Console.WriteLine("Programa que realiza multiplicaciones\n");
            Console.WriteLine("[1] Imprimir una tabla de multiplicar específica hasta cierto número ");
            Console.WriteLine("[2] Imprimir las tablas deseadas hasta el número deseado.");

          }
    }
}

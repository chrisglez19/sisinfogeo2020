using System;

namespace ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            empleado empleado01 = new empleado();

            empleado empleado02;
            empleado02 = new empleado();

            //Por medio del constructor podemos darle los parametros de nombre y edad directamente
            empleado empleado03 = new empleado("Maria",30);

            empleado01.Nombre = "Juan Penas";
            empleado01.Edad = 30;

            empleado02.Nombre = "Jhon Pen";
            empleado02.Edad = 31;

            
            Console.WriteLine(empleado01.ToString());
            Console.WriteLine($"Te vas de vacaciones:\n{DateTime.Now.ToString("dd/MM/yy")}\nRegresas:");
            Console.Write(empleado01.Vacaciones(DateTime.Now,30));
        }
    }
}

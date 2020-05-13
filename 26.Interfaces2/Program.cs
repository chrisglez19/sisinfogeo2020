using System;

namespace _26.Interfaces2
{
    public class Organismo{
        public void Respiracion(){
            Console.WriteLine("Respiracion");
        }
        public void Movimiento(){
            Console.WriteLine("Movimiento");
        }
        public void Crecimiento(){
            Console.WriteLine("Crecimiento");
        }
    }
    
    public interface IAnimales
    {
        void Multicelular();
        void SangreCaliente();
    }

    public interface ICanino : IAnimales
    {
        void Corre();
        void CuatroPatas();
    } 

    public interface IPajaro : IAnimales
    {
        void Vuela();
        void DosPatas();
    }  

    public class Perro : Organismo, ICanino {
        public void Multicelular()=>Console.WriteLine("Multicelular");
        public void SangreCaliente()=>Console.WriteLine("Sangre Caliente");
        public void Corre()=>Console.WriteLine("Corre");
        public void CuatroPatas()=>Console.WriteLine("Cuatro Patas");
    }

    public class Perico : Organismo, IPajaro {
        public void Multicelular()=>Console.WriteLine("Multicelular");
        public void SangreCaliente()=>Console.WriteLine("Sangre Caliente");
        public void Vuela()=>Console.WriteLine("Vuela");
        public void DosPatas()=>Console.WriteLine("Dos Patas");
    }

    class Program
    {
        static void Main(string[] args)
        {
            Perro perro = new Perro();
            Console.WriteLine("\nCaracteristics del Perro\n");
            perro.Respiracion();
            perro.Movimiento();
            perro.Crecimiento();
            perro.Corre();
            perro.CuatroPatas();

            Perico perico = new Perico();
            Console.WriteLine("\nCaracteristics del Perico\n");
            perico.Respiracion();
            perico.Movimiento();
            perico.Crecimiento();
            perico.Vuela();
            perico.DosPatas();
        }

    }
}

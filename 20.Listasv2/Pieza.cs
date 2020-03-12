using System;

namespace _20.Listasv2
{
    class Pieza
    {
        public Pieza(int id, string nombre) => (Id, Nombre)=(id,nombre);
        public int Id {get; set;}
        /*private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }*/
        public string Nombre {get; set;}
        //Sobrecargar 
        public override string ToString() => $"{Id} - {Nombre}";
    }
}

using System;
using System.Collections.Generic;

namespace _1.Parcial1
{
    class Vulnerabilidad
    {
        private string clave;
        private string vendedor;
        private string descripcion;
        private string tipo;
        private string fecha;

        public Vulnerabilidad(string clave, string vendedor, string descripcion, string tipo, string fecha)
        {
            this.clave=clave;
            this.vendedor=vendedor;
            this.descripcion=descripcion;
            this.tipo=tipo;
            this.fecha=fecha;
        }
        
        }
    }
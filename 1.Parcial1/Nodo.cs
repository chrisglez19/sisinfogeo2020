using System;
using System.Collections.Generic;

namespace _1.Parcial1
{
    class Nodo
    {
        private string ip;
        private string tipo;
        private string puertos;
        private int saltos;
        private string so;
        private List<Vulnerabilidad> vulnerabilidades;

          public Nodo(string ip, string tipo, string puertos, int saltos, string so) {
            this.ip=ip;
            this.tipo=tipo;
            this.puertos=puertos;
            this.saltos=saltos;
            this.so=so;
            
            vulnerabilidades=new List<Vulnerabilidad>();
        }
        public string Ip{
            get { return ip; }
            set { ip = value; }
        }

        public string Tipo{
            get { return tipo; }
            set { tipo = value; }
        }

        public string Puertos{
            get { return puertos; }
            set { puertos = value; }
        }

        public int Saltos{
            get { return saltos; }
            set { saltos = value; }
        }
        public string So{
            get { return so; }
            set { so = value; }
        }


        public List<Vulnerabilidad> Vulnerabilidades
        {
            get { return vulnerabilidades; }   
        }
        public void AgregarVulnerabilidad(Vulnerabilidad vul){
            vulnerabilidades.Add(vul);
        }
    }
}
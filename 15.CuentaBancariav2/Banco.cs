using System;
using System.Collections.Generic;

namespace _14.CuentaBancaria {
    class Banco {
        private string nombreBanco;
        private string propietario;
        private List<Cliente> clientes;

        public Banco(string nombreBanco, string propietario){
            this.nombreBanco=nombreBanco;
            this.propietario=propietario;
            clientes=new List<Cliente>();
        }
        public string NombreBanco
        {
            get { return nombreBanco; }
            set { nombreBanco = value; }
        }
        
        public string Propietario
        {
            get { return propietario; }
            set { propietario = value; }
        }

        public void AgregarCliente(Cliente cte){
            clientes.Add(cte);
        }

        public List<Cliente> Clientes {
            get {return clientes;}
        }



        
    }
}
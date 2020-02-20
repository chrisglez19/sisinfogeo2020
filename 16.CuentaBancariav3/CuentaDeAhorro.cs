using System;

namespace _14.CuentaBancaria
{
    class CuentaDeAhorro : CuentaBancaria       //heredamos de cuenta bancaria
    {      
        private double tasaInteres;
        public CuentaDeAhorro(double saldo, double tasaInteres)
            :base(saldo)    // llamada explicita al constructor de la clase base
        {
            this.tasaInteres=tasaInteres;
        }
        
        public void CalcularInteres(){
            saldo+=(saldo*tasaInteres);

        }
    }
}
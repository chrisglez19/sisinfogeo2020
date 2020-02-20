namespace _14.CuentaBancaria
{
    class CuentaBancaria{
        public double saldo; 

        public CuentaBancaria(double saldo){
            this.saldo=saldo;
        }

        public double Saldo {
            get {return saldo;}
        }

        public void Deposita(double cantidad){
            saldo+=cantidad;
            
        }
        //metodo virtual que podra ser sobrecargada por la clase  que lo herede
        public virtual bool Retira (double cant){
            if(saldo>=cant){
                saldo-=cant;
                return true;
            }else return false;
        }

    }
}
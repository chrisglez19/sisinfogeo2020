using System;

namespace ej1
{
    class empleado
    {
       
            private string nombre;
            private int edad;

            //CONSTRUCTOR(ES)
            public empleado(){

            }
            public empleado(string nombre, int edad){
                this.nombre=nombre;
                this.edad=edad;
            }
            public string Nombre {
                get {return nombre;}
                set{nombre= value;}
            }

            public int Edad {
                get {return edad;}
                set{edad= value;}
            }

            //metodo de la clase
            public string Vacaciones(DateTime ini, int dias){
                DateTime fin;
                fin = ini.AddDays(dias);
                return fin.ToString("dd/MM/yy");
            }
            //sobrecargamos el metodo ToString heredado de la clase Base (Object)
            public override string ToString(){
                return $"Nombre: {nombre}, Edad: {edad}";
            }
      
    }
}


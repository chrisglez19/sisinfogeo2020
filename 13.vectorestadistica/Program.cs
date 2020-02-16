using System;

namespace _13.vectorestadistica
{
    class Program
    {
        static void Main(string[] args)
        {
            int t, a;

            t=int.Parse(args[0]);
            double[] A = new double[t];

            for(int i=0; i<t; i++){

                a=int.Parse(args[i+1]);

                A[i]= a;
                
            }

            for(int i=0; i<t; i++){

                Console.Write($"{A[i]} ");
            }


            Console.WriteLine($"\n\nEl elemento mayor es: {Mayor(A, t)}\n");
            Console.WriteLine($"El elemento menor es: {Menor(A, t)}\n");
            Console.WriteLine($"El promedio es: {Promedio(A, t)}\n");
            Console.WriteLine($"La varianza es: {Varianza(A, t, Promedio(A, t))}\n");
            Console.WriteLine($"La desviacion estandar es: {DesvEst(A, t)} \n");
        }

        static double Mayor(double [] v1, int t1){

            double na=0, nm=0;

            for(int i=0; i<t1; i++){

                na=v1[i];

                if(na>nm)
                    nm=na;
            }

            return nm;
        }

        static double Menor(double[] v2, int t2){

            double na, nme=v2[0]; 

            for(int i=0; i<t2; i++){

                na=v2[i];

                if(na<nme)
                    nme=na;
            }

            return nme;
        }

        static double Promedio(double[] v3, int t3){

            double prom=0, suma=0;

            for(int i=0; i<t3; i++){

                suma+=v3[i];

            }

            return prom=suma/t3;

        }

        static double Varianza(double[] v4, int t4, double prom4){

            double p1=0;
            double[] v41= new double[t4];
            double[] v42= new double[t4];

            for(int i=0; i<t4; i++)
                v41[i]= v4[i]-prom4;


            for(int j=0; j<t4; j++)
                p1+= Math.Pow(v41[j],2);

            return p1/(t4-1);

        }

        static double DesvEst(double[] v5, int t5){

            double med1=0, med2=0, suma1=0, suma2=0, de=0;
            double[] d1 = new double[t5];

            for(int i=0; i<t5; i++)                
                med1+=v5[i];
            
            med2=med1/4;

            //Console.WriteLine($"{med2}");


            for(int i=0; i<t5; i++)
                suma1+=Math.Pow(v5[i]-med2, 2); 

            //Console.WriteLine($"{suma1}");
            suma2=suma1/t5;
            //Console.WriteLine($"{suma2}");

            de=Math.Sqrt(suma2);

            //Console.WriteLine($"{de}");

            return de;
        } 
        
    }
}
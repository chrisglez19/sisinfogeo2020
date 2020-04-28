using System;
using System.IO; 
using CsvHelper; 
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
namespace _2.Parcial2
{
    class Program
    {
      

        static void Main(string[] args)
        {
            int op;
            
            if (args.Length==0) Menu();

            op= int.Parse(args[0]);

            // Declara lista y lectura de csv
            List<Empleado> empleados = new List<Empleado>();
            empleados=Leer("datos.csv");

            // Nuevos empleados
            empleados.Add(new Empleado {Rfc="CARC771123", Nombre="CARLOS CASTANEDA RODRIGUEZ        ", Area="JUBILADOS    ", Salario= 5456.66});
            empleados.Add(new Empleado {Rfc="SOBR711202", Nombre="ROCIO SOTO BOTELLO                ", Area="JUBILADOS    ", Salario=6423.66});
            empleados.Add(new Empleado {Rfc="SUGA791124", Nombre="ARACELI SUSTAITA GOMEZ            ", Area="PROMOCION    ", Salario=2380});
            empleados.Add(new Empleado {Rfc="DEAM690813", Nombre="MARGARITA DELGADILLO ARCE         ", Area="PROMOCION    ", Salario=1858});
            empleados.Add(new Empleado {Rfc="PETT670521", Nombre="PEREZ TORRES MARIA TRINIDAD       ", Area="PROMOCION    ", Salario=1851});
            empleados.Add(new Empleado {Rfc="ROLE771004", Nombre="ERIKA FRANCISCA ROBLES LOPEZ      ", Area="JUBILADOS    ", Salario=4691.44});
            empleados.Add(new Empleado {Rfc="LERK911214", Nombre="KARELY GUADALUPE LEAL RAMOS       ", Area="DEPORTE      ", Salario=1223.66});
            empleados.Add(new Empleado {Rfc="BEAY911116", Nombre="YESICA BERUMEN ACOSTA             ", Area="CULTURA      ", Salario=6423.66});

            // Escribe todos los empleados en el nuevo csv llamado nomina
            Escribir(empleados,"nomina.csv");

            // Lee archivo nomina
            List<Empleado> empleadosNomina = new List<Empleado>();
            empleadosNomina=Leer("nomina.csv");
           
            
            switch (op){
                case 1:{
                     Console.WriteLine("\nListado de nomina orden original:\n");
                     empleadosNomina.ForEach(enom=>Console.WriteLine(enom.ToString()));
                     Console.WriteLine("Total: "+ empleadosNomina.Count());
                }break;
                case 2:{
                        Console.WriteLine("\nListado de nomina orden por nombre:\n");
                        var l2 = (                              
                        from enom in empleadosNomina
                        orderby enom.Nombre                     // Orden por nombre
                        select enom).ToList();
                        l2.ForEach(enom=>Console.WriteLine(enom.ToString()));
                        Console.WriteLine("Total: "+l2.Count());
                       
                }break;
                case 3:{
                        Console.WriteLine("\nListado de nomina ordenado por salario:\n");
                        var l3 = (                              
                        from sal in empleadosNomina
                        orderby sal.Salario descending                    // Orden por salario
                        select sal).ToList();
                        l3.ForEach(sal=>Console.WriteLine(sal.ToString()));
                        Console.WriteLine("Total: "+l3.Count());
                }break;
                case 4:{
                        Console.WriteLine("\nListado de nomina con salario > 3500:\n");
                        var l4 = (                              
                        from sal in empleadosNomina
                        where sal.Salario>3500                    // sal mayor a 3500
                        select sal).ToList();
                        l4.ForEach(sal=>Console.WriteLine(sal.ToString()));
                        Console.WriteLine("Total: "+l4.Count());
                }break;
                case 5:{
                        Console.WriteLine("\nListado de nomina con 77 en el Rfc:\n");
                        var l5 = (                              
                        from rfc in empleadosNomina
                        where rfc.Rfc.Contains("77")                   // rfc con 77
                        select rfc).ToList();
                        l5.ForEach(rfc=>Console.WriteLine(rfc.ToString()));
                        Console.WriteLine("Total: "+l5.Count());
                }break;
                case 6:{
                        Console.WriteLine("\nListado de nomina con los JUBILADOS:\n");
                        var l6 = (                              
                        from area in empleadosNomina
                        where area.Area.Contains("JUBILADOS")                   // Area de JUBILADOS
                        select area).ToList();
                        l6.ForEach(area=>Console.WriteLine(area.ToString()));
                        Console.WriteLine("Total: "+l6.Count());
                }break;
                case 7:{
                        Console.WriteLine("\nListado de nomina agrupado por area:\n");
                        double suma17a= 0;
                        double suma17d= 0;
                        double suma17p= 0;
                        double suma17j= 0;
                        double suma17c= 0;
                        double sumaTotal;
                        Console.WriteLine("\nAGROPECUARIO:\n");
                        var l7a = (                              
                        from area in empleadosNomina
                        where area.Area.Contains("AGROPECUARIO")                   // Area de AGROPECUARIO
                        select area).ToList();
                        l7a.ForEach(area=>Console.WriteLine(area.ToString()));
                        l7a.ForEach(area=>suma17a=area.Salario+suma17a);
                        Console.WriteLine("Total: "+l7a.Count()+" - "+suma17a);

                        Console.WriteLine("\nDEPORTE:\n");
                        var l7d = (                              
                        from area in empleadosNomina
                        where area.Area.Contains("DEPORTE")                   // Area de DEPORTE
                        select area).ToList();
                        l7d.ForEach(area=>Console.WriteLine(area.ToString()));
                        l7d.ForEach(area=>suma17d=area.Salario+suma17d);
                        Console.WriteLine("Total: "+l7d.Count()+" - "+suma17d);

                        Console.WriteLine("\nPROMOCION:\n");
                        var l7p = (                              
                        from area in empleadosNomina
                        where area.Area.Contains("PROMOCION")                   // Area de PROMOCION
                        select area).ToList();
                        l7p.ForEach(area=>Console.WriteLine(area.ToString()));
                        l7p.ForEach(area=>suma17p=area.Salario+suma17p);
                        Console.WriteLine("Total: "+l7p.Count()+" - "+suma17p);

                        Console.WriteLine("\nJUBILADOS:\n");
                        var l7j = (                              
                        from area in empleadosNomina
                        where area.Area.Contains("JUBILADOS")                   // Area de JUBILADOS
                        select area).ToList();
                        l7j.ForEach(area=>Console.WriteLine(area.ToString()));
                        l7j.ForEach(area=>suma17j=area.Salario+suma17j);
                        Console.WriteLine("Total: "+l7j.Count()+" - "+suma17j);

                        Console.WriteLine("\nCULTURA:\n");
                        var l7c = (                              
                        from area in empleadosNomina
                        where area.Area.Contains("CULTURA")                   // Area de CULTURA
                        select area).ToList();
                        l7c.ForEach(area=>Console.WriteLine(area.ToString()));
                        l7c.ForEach(area=>suma17c=area.Salario+suma17c);
                        Console.WriteLine("Total: "+l7c.Count()+" - "+suma17c);

                        sumaTotal= suma17a+suma17d+ suma17p+suma17j+suma17c;
                        Console.WriteLine("\nTotal Areas: 5 - "+sumaTotal+"\n");

                }break;
                default:{ 
                        Console.WriteLine("\nESCRIBE UNA OPCION VALIDA\n");
                        Menu();
                }break;
            }
       

        }
        
             // regresa los datos de la lista
        public static List<Empleado> Leer(string file) {
            using (var  lectura = new StreamReader(file))
            using (var csv = new CsvReader(lectura,CultureInfo.InvariantCulture))
            {
                csv.Configuration.HasHeaderRecord=false;
                csv.Read();
                var records=csv.GetRecords<Empleado>().ToList();
                return records;
            }
        }


        // Guarda todos los datos de la lista
        public static void Escribir(List<Empleado> records, string file) {
             using (var escritura = new StreamWriter(file))
            using (var csv = new CsvWriter(escritura, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(records);
            }           
        } 

        static void Menu() {
            Console.WriteLine("Listado de nomina orden original ........ [1]");
            Console.WriteLine("Listado de nomina ordenado por nombre ... [2]");
            Console.WriteLine("Listado de nomina ordenado por salario .. [3]");
            Console.WriteLine("Listado de nomina con salario > 3500 .... [4]");
            Console.WriteLine("Listado de nomina con 77 en el Rfc ...... [5]");
            Console.WriteLine("Listado de nomina con los JUBILADOS ..... [6]");
            Console.WriteLine("Listado de nomina agrupado por area ..... [7]");
            
        }
        
    }
}
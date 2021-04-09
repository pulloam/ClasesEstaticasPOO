using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraAplicacion
{
    class Program
    {
        static void Main(string[] args){
            Bip b = new Bip("ID-999");
            Bip b1 = new Bip("ID-100");

            b1.Cargar(30000);
            Bip.ENTIDAD = "CORPBANCA";


            b.Cargar(1000);

            Console.WriteLine("Id {0}, Saldo {1}",b.Id, b.Saldo);



            //ClaseEstatica.ClaveSegura("aaa");
            //ClaseEstatica.Dolar = 730.43;
            //ClaseEstatica.Dolar = 18;

            //ClaseEstatica c1 = new ClaseEstatica();
            //c1.Valores_Pasaje(0);
            //ClaseEstatica c2 = new ClaseEstatica();
            //ClaseEstatica c3 = new ClaseEstatica();
            //c1.Dolar = 730;
            //c2.Dolar = 740;
            //c3.Dolar = 600;

           
            ClaseEstatica.DOLAR_OBS = 730.4;
            ClaseEstatica.DOLAR_OBS = 740.1;

            Console.WriteLine(ClaseEstatica.Valores_Pasaje());

            //Parsear un string a un numero
            Console.Write("Ing. Número : ");
            string numero = Console.ReadLine();

            try {
                int num;
            
                num = int.Parse(numero);//Si no es un numero se cae el programa, debemos usar try catch

                if(int.TryParse(numero, out num)) { 
                    Console.WriteLine("Se parseó bien");
                } else {
                    num = -1;
                    Console.WriteLine("No se puede convertir a número");    
                }


            } catch (FormatException ex) {
                Console.WriteLine("Debe ingresar número \n" + ex.Message);
            } catch(Exception ex) { 
                Console.WriteLine("Error -> " + ex.ToString());    
            }

            Console.ReadKey();

            

           

        }
    }
}

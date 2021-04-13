using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraAplicacion {
    class ClaseEstatica {
        public static readonly double IVA = 19;
        public static double DOLAR_OBS = 740.4;

        private static int[] Valor_Pasaje_Dia = {500, 600, 450, 700, 300, 200, 100 };

        private static int[,] Valor_Pasaje_Horario = {
            { 100, 330, 100 },
            { 331, 500, 50 },
            { 1400, 2100, 300 }
         };

         public static int ValorPasaje(int dia, int hora){ 
            //TODO: Buscar según dia y hora en los arreglos para retornar valor final del pasaje 
            return 700;
         }

        private ClaseEstatica() { }

        public static int Suma(int a, int b) { 

            return a + b;
        }

        public static bool ClaveSegura(string clave) { 
            return clave.Length >= 8;    
        }

        public static int Resta(int a, int b) { return a - b;}

        public static string Valores_Pasaje() { 
            string pasajes = "";

            for (int x = 0; x < Valor_Pasaje_Dia.Length; x++) {
                pasajes += Valor_Pasaje_Dia[x].ToString();
            } 

            pasajes = "";
            foreach (int dia in Valor_Pasaje_Dia) {
                pasajes += dia.ToString() + "\n" ;
            }

            Console.WriteLine("\n\n" + Valor_Pasaje_Horario[1,1].ToString());
            Console.WriteLine("\n\n" + Valor_Pasaje_Horario.ToString());

            return pasajes;
        }






    }
}

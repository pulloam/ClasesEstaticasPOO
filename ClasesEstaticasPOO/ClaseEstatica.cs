using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraAplicacion {
    class ClaseEstatica {
        private static int[,,] valoresPasajes = {
            { //Lunes[0]
                {9999, 9999, 300 },//Valor del día
                {0000, 0800, 200 },// + cargo de las 00 a las 08 $200
                {0801, 1400, 100 },// + cargo de las 08:01 a las 14:00 $100
                {1401, 2359, 300 }// + cargo de las 14:01 a las 23:59 $300
            },
            {//Martes [1]
                {9999, 9999, 300 },//Valor del día
                {0000, 0800, 200 },// + cargo de las 00 a las 08am $200
                {0801, 1400, 100},// + cargo de las 08:01 a las 14:00 $100
                {1401, 2359, 500 }// + cargo de las 14:01 a las 23:59 $500
            },
            {//Miércoles[2]
                {9999, 9999, 300 },//Valor del día
                {0000, 0800, 200 },// 
                {0801, 1400, 100 },// 
                {1401, 2359, 300 }// 
            },
            {//Jueves[3]
                {9999, 9999, 600 },//Valor del día
                {0000, 0800, 200 },// 
                {0801, 1400, 400 },// 
                {1401, 2359, 500 }// 
            }
        };

        public static int ValorPasaje(){ 
            DateTime diaHoy = DateTime.Now;
            int diaSemana = (int)diaHoy.DayOfWeek;
            int hora = diaHoy.Hour * 10;
            int min = diaHoy.Minute;

            string horaStr = diaHoy.ToString("HHmm");
            int horaInt = int.Parse(horaStr);

            

            diaSemana = diaSemana - 1;
            if(diaSemana == -1) diaSemana = 6;

            Console.WriteLine("Día semana {0} en números es {1} ",diaHoy.DayOfWeek,diaSemana);
            Console.WriteLine("Hora " + hora + "" + min);

            return BuscarDiaHoraPasaje(diaSemana, hora);
        }

        //private static int[,,] valores = new  int[7,24,3];

        //public static void PoblarValoresPasajes(){ 
        //    valores[0,0,2] = 300;
        //    valores[0,1,2] = 500;
        //    valores[0,0,1] = 999;
        //    valores[0,0,1] = 999;
            
        
        
        //}

         public static int ValorPasaje(int dia, int hora){ 
            return BuscarDiaHoraPasaje(dia, hora);
         }

         
         private static int BuscarDiaHoraPasaje(int dia, int hora){ 
            //TODO: Buscar según los parametros de entrada el valor del pasaje
            return 0;
         }

        private ClaseEstatica() { }



    }
}

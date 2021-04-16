using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraAplicacion {
    class Bip {
        public DateTime FechaCreacion { get;}

        public string[] Cargas = new string[10];

        private string[] viajes = new string[10];
        

        public static string ENTIDAD = "BCI";



        public string Id {get; }
        public string Banco {get;set; }

        private int saldo;
        public int Saldo{
            get{ return saldo; }
        }

        public bool Cargar(int monto) { 
            if(monto > 0) {
                saldo = saldo + monto;
                return true;
            }

            return false;
        }

        public bool Pagar() { 
            ClaseEstatica.ValorPasaje(0, 1405);

            return false;
        }

        public Bip(string id) { 
            Id = id;
            saldo = 10000;

            FechaCreacion = DateTime.Now;
           

        }


    }
}

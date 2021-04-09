using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraAplicacion
{
    class Cliente{
        public string Rut { get; set; }

        private int edad;
        public int Edad
        {

            get { return edad; }

            set {
                if (value >= 0){
                    edad = value;
                }else {
                    edad = value * -1;
                }
            }

        }


        public Cliente(string rut) {
            this.Rut = rut;
        }

        public Cliente() { }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos_g3.Clases
{
    abstract class Terrestre : Vehiculo
    {
       protected byte cant_ruedas;

        protected Terrestre(string fabricante,byte cant_puertas) : base(fabricante)
        {
            Cant_ruedas = cant_ruedas;
        }

        public byte Cant_ruedas { get => cant_ruedas; 
            set 
            {
                if (value > 0) cant_ruedas = value;
                else throw new Exception("la cantidad de ruedas debe de ser mayor a cero");
            } 
        }
    }
}

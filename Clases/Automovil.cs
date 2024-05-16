using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos_g3.Clases
{
    class Automovil:Terrestre
    {
        private byte cant_puertas;

        public Automovil(string fabricante, byte cant_ruedas,byte cant_puertas) : base(fabricante, cant_ruedas)
        {
            Cant_puertas = cant_puertas;
        }

        public byte Cant_puertas { get => cant_puertas; set
            {
                if (value > 0 && value<6) cant_puertas = value;
                else throw new Exception("la cantidad debe de ser mayor a cero");
            }
        }
        public override string Acelerar(ushort vel_final)
        {
            try
            {
                return "Acelerando auto";
            }
            catch (Exception)
            {
                return "error acelerando auto";
            }

        }

        public override string Desacelerar(ushort vel_final)
        {
            try
            {
                return "Desacelerando auto";
            }
            catch (Exception)
            {
                return "error Desacelerando auto";
            }
        }
    }
}

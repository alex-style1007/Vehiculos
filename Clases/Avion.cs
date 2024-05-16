using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos_g3.Clases
{
    abstract class Avion:Aereo
    {
        private ushort cap_carga;

        public Avion(string fabricante, float envergadura,ushort cap_carga) : base(fabricante, envergadura)
        {
            Cap_carga = cap_carga;
        }

        public ushort Cap_carga { get => cap_carga; set
            {
                if (value > 0) cap_carga = value;
                else throw new Exception("la cantidad debe de ser mayor a cero");
            }
        }
        public override string Despegar(float Altura, ushort velocidad)
        {
            try
            {
                return "avion despegando";
            }
            catch (Exception)
            {
                return "error aereo al despegar";
            }
        }
       
        public override string Aterrizar(float Altura, ushort velocidad)
        {
            try
            {
                return "avion aterrizando";
            }
            catch (Exception)
            {
                return "avion aereo al aterrizar";
            }
        }
        public override string Acelerar(ushort vel_final)
        {
            try
            {
                return "Acelerando avion";
            }
            catch (Exception)
            {
                return "error acelerando avion";
            }

        }

        public override string Desacelerar(ushort vel_final)
        {
            try
            {
                return "Desacelerando avion";
            }
            catch (Exception)
            {
                return "error Desacelerando avion";
            }
        }
    }
}

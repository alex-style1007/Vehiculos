using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos_g3.Clases
{
    abstract class Aereo : Vehiculo
    {
        protected float envergadura;

        protected Aereo(string fabricante, float envergadura) : base(fabricante)
        {
            Envergadura = envergadura;
        }

        public float Envergadura
        {
            get => envergadura; set
            {
                if (value > 0) envergadura = value;
                else throw new Exception("la envergadura debe de ser mayor a cero");
            }
        }
        public virtual string Despegar(float Altura,ushort velocidad)
        {
            try
            {
                return "aereo despegando";
            }
            catch (Exception)
            {
                return "error aereo al despegar";
            }
        }
        public virtual string Aterrizar(float Altura, ushort velocidad)
        {
            try
            {
                return "aereo aterrizando";
            }
            catch (Exception)
            {
                return "error aereo al aterrizar";
            }
        }
    }
}

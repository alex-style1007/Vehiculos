using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos_g3.Clases
{
    class Planeador : Aereo
    {
        private byte nro_puestos;

        public Planeador(string fabricante, float envergadura, byte nro_puestos) : base(fabricante, envergadura)
        {
            Nro_puestos = nro_puestos;
        }

        public byte Nro_puestos
        {
            get => nro_puestos; set
            {
                {
                    if (value > 0) nro_puestos = value;
                    else throw new Exception("la cantidad debe de ser mayor a cero");
                }
            }
        }
        public override string Acelerar(ushort vel_final)
        {
            try
            {
                return "Acelerando planeador";
            }
            catch (Exception)
            {
                return "error acelerando planeador";
            }

        }

        public override string Desacelerar(ushort vel_final)
        {
            try
            {
                return "Desacelerando planeador";
            }
            catch (Exception)
            {
                return "error Desacelerando planeador";
            }
        }
        public override string Despegar(float Altura, ushort velocidad)
        {
            try
            {
                return "planeador despegando";
            }
            catch (Exception)
            {
                return "error aereo al planeador";
            }
        }
    }
}

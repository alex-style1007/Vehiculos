using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos_g3.Clases
{
    class Comercial:Avion
    {
        private ushort cant_pasajeros;
        public Comercial(string fabricante, float envergadura, ushort cap_carga,ushort cant_pasajeros)
            : base(fabricante, envergadura, cap_carga)
        {
            Cant_pasajeros = cant_pasajeros;
        }

        public ushort Cant_pasajeros { get => cant_pasajeros;
            set
            {
                if (value < 0) cant_pasajeros = value;
                else throw new Exception("cantidad de pasajeros no puede ser cero");
                        
                    
            } }

        public override string Acelerar(ushort vel_final)
        {
            try
            {
                return "Acelerando avion comercial";
            }
            catch (Exception)
            {
                return "error acelerando avion comercial";
            }

        }

        public override string Desacelerar(ushort vel_final)
        {
            try
            {
                return "Desacelerando avion comercial";
            }
            catch (Exception)
            {
                return "error Desacelerando avion comercial";
            }
        }
        public override string Despegar(float Altura, ushort velocidad)
        {
            try
            {
                return "Despegando avion comercial";
            }
            catch (Exception)
            {
                return "error despegando avion comercial";
            }
        }
    }
}

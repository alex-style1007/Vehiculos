using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Vehiculos_g3.Interfaces;
using System.Threading.Tasks;

namespace Vehiculos_g3.Clases
{
    class Combate : Avion, IDisparar
    {
        private float calibre_canon;
        public Combate(string fabricante, float envergadura, ushort cap_carga,float calibre_canon) 
            : base(fabricante, envergadura, cap_carga)
        {
            Calibre_canon = calibre_canon;
        }

        public float Calibre_canon { get => calibre_canon; 
            set
            {
                if (value > 0) calibre_canon = value;
                else throw new Exception("el calibre del cañon no puede ser cero");
            }
                }
        public override string Acelerar(ushort vel_final)
        {
            try
            {
                return "Acelerando avion de combate";
            }
            catch (Exception)
            {
                return "error acelerando avion de combate";
            }

        }

        public override string Desacelerar(ushort vel_final)
        {
            try
            {
                return "Desacelerando avion de combate";
            }
            catch (Exception)
            {
                return "error Desacelerando avion de combate";
            }
        }

        public string Disparar(ushort cant_municiones)
        {
            try
            {
                return " avion de combate disparando";
            }
            catch (Exception)
            {
                return "error disparando el avion de combate";
            }
        }
        public override string Aterrizar(float Altura, ushort velocidad)
        {
            try
            {
                return " avion de combate aterrizando";
            }
            catch (Exception)
            {
                return "error al aterrizar el avion de combate";
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos_g3.Clases
{
    abstract class Vehiculo
    {
        protected string fabricante;

        public Vehiculo(string fabricante)
        {
            Fabricante = fabricante ?? throw new ArgumentNullException(nameof(fabricante));
        }

        public string Fabricante { get => fabricante;
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                    throw new Exception("No se puede tener el fabricante en Nulo o en blanco");
                else fabricante = value;
            }
         }
        public abstract string Acelerar(ushort vel_final);//cuando el metodo es abstracto solo se define
        public abstract string Desacelerar(ushort vel_final);
    }
}

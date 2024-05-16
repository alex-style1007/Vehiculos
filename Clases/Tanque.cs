using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Vehiculos_g3.Interfaces;
using System.Threading.Tasks;

namespace Vehiculos_g3.Clases
{
    class Tanque:Terrestre,IDisparar
    {
        private byte nro_ocupantes;

        public Tanque(string fabricante, byte cant_ruedas,byte nro_ocupantes) : base(fabricante, cant_ruedas)
        {
        }

        protected byte Nro_ocupantes { get => nro_ocupantes; set {
                if (value > 0) nro_ocupantes = value;
                else throw new Exception("la cantidad debe de ser mayor a cero");
            } }

        public override string Acelerar(ushort vel_final)
        {
            try
            {
                return "Acelerando tanque";
            }
            catch(Exception)
            {
                return "error acelerando tanque";
            }
            
        }

        public override string Desacelerar(ushort vel_final)
        {
            try
            {
                return "Desacelerando tanque";
            }
            catch (Exception)
            {
                return "error Desacelerando tanque";
            }
        }
        public string Disparar(ushort cant_municiones)
        {
            try
            {
                return " tanque disparando";
            }
            catch (Exception)
            {
                return "error disparando tanque";
            }
        }
    }
}

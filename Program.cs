using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Vehiculos_g3.Clases;
using System.Threading.Tasks;

namespace Vehiculos_g3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tanque tanq_1 = new Tanque("general dinamica", 14, 2);
                Combate avion_c2 = new Combate("rocwell", 37.6f, 8, 20f);

                Console.WriteLine(avion_c2.Disparar(1500) + "\n");
                Console.WriteLine(tanq_1.Disparar(2000) + "\n");


            }
            catch (Exception error)
            {
                Console.WriteLine("ocurrio un error en" + error);
            }
            finally 
            {
                Console.ReadKey();
            }

        }
    }
}

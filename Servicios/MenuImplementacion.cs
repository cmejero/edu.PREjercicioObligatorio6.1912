using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.EjercicioObligatorio6._1912.Servicios
{
    /// <summary>
    /// Implementación de la interfaz
    /// <author>CMR - 16-01-2024</author>
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {

        public int menuYSeleccion()
        {
            int opcionSeleccionada;

            Console.WriteLine("######################");
            Console.WriteLine("0. Cerrar Menu");
            Console.WriteLine("1. Dar de alta cliente");
            Console.WriteLine("2. Ordenar lista clientes");
            Console.WriteLine("######################");

            opcionSeleccionada = Convert.ToInt32(Console.ReadLine());
            return opcionSeleccionada;
            
        }
    }
}

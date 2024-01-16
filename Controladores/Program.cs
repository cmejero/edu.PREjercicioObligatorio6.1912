using edu.EjercicioObligatorio6._1912.Dtos;
using edu.EjercicioObligatorio6._1912.Servicios;
using System.Collections;
using System.Collections.Generic;

namespace edu.EjercicioObligatorio6._1912.Controladores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MenuInterfaz mi = new MenuImplementacion(); 
            OperacionInterfaz oi = new OperacionImplementacion();

            List<UsuariosDto> listaUsuario = new List<UsuariosDto>();
            

            int opcionUsuario;
            bool cerrarMenu = false;

            while (!cerrarMenu)
            {
                opcionUsuario = mi.menuYSeleccion();
                Console.WriteLine(opcionUsuario);

                switch (opcionUsuario)
                {
                    case 0:
                        Console.WriteLine("Has seleccionado cerrar menu");
                        cerrarMenu = true;
                        break;

                    case 1:
                        Console.WriteLine("Has seleccionado dar de alta a cliente");
                        oi.agregarUsuario(listaUsuario);
                        break;

                    case 2:
                        Console.WriteLine("Has seleccionado ordenar lista cliente");
                        oi.ordenarLista(listaUsuario);
                        break;

                    default:
                        Console.WriteLine("La opcion seleccionada no corresponde con ninguna");
                        break;
                        

                }
            }
        }
    }
}
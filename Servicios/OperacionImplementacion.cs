using edu.EjercicioObligatorio6._1912.Dtos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.EjercicioObligatorio6._1912.Servicios
{
    /// <summary>
    ///  Implementacion la operativaInterfaz
    ///  <author>CMR - 16-01-2024</author>
    /// </summary>
    internal class OperacionImplementacion : OperacionInterfaz
    {
        public void agregarUsuario(List<UsuariosDto> listaAntigua)
        {
            listaAntigua.Add(crearUsuario());
        }

        /// <summary>
        /// Metodo que se encarga de crear/rellenar los campos necesarios
        /// <author>CMR - 16-01-2024</author>
        /// </summary>
        /// <returns></returns>
        private UsuariosDto crearUsuario()
        {
            Console.WriteLine("Introduzca un id");
            long id = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Introduzca un nombre");
            string nombre= Console.ReadLine();

            Console.WriteLine("Introduzca apellidos");
            string apellidos = Console.ReadLine();

            Console.WriteLine("Introduzca su edad");
            int edad= Convert.ToInt32(Console.ReadLine());

            return new UsuariosDto(id, nombre, apellidos , edad);
        }

        public void ordenarLista(List<UsuariosDto> listaAntigua)
        {
            if (listaAntigua.Count >= 3)
            {
                Console.WriteLine("USUARIOS INTRODUCIDOS EN LA LISTA");
                for (int i = 0; i < listaAntigua.Count; i++)
                {

                    Console.WriteLine("NOMBRE CLIENTE: " + listaAntigua[i].NombreCompletoCliente + " " + "EDAD CLIENTE: " + listaAntigua[i].Edad);
                }

                Console.WriteLine("USUARIOS DE LA LISTA ORDENADOS DESCENDENTEMENTE POR EDAD");

                for (int i = 0; i < listaAntigua.Count - 1; i++)
                {
                    for (int j = 0; j < listaAntigua.Count - 1 - i; j++)
                    {
                        if (listaAntigua[j].Edad > listaAntigua[j + 1].Edad)
                        {
                            {
                                UsuariosDto aux = listaAntigua[j];
                                listaAntigua[j] = listaAntigua[j + 1];
                                listaAntigua[j + 1] = aux;


                            }

                        }
                    }
                }
                for (int v = 0; v < listaAntigua.Count; v++)
                {
                    Console.WriteLine("NOMBRE CLIENTE: " + listaAntigua[v].NombreCompletoCliente + " " + "EDAD CLIENTE: " + listaAntigua[v].Edad);
                }


            }


            else
            {
                Console.WriteLine("SON NECESARIOS AL MENOS 3 CLIENTES PARA REALIZAR ESTA ACCIÓN");
            }


            

        }

    }
}

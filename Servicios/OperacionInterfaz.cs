using edu.EjercicioObligatorio6._1912.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.EjercicioObligatorio6._1912.Servicios
{
    /// <summary>
    /// Clase que se encarga de la operativa de nuestra aplicación
    /// <author>CMR - 16-01-2024</author>
    /// </summary>
    internal interface OperacionInterfaz
    {
        /// <summary>
        /// Método que se encarga de añadir nuevos elementos a lista
        /// <author>CMR - 16-01-2024</author>
        /// </summary>
        /// <param name="listaAntigua"></param>
        public void agregarUsuario(List<UsuariosDto> listaAntigua);

        /// <summary>
        /// Método que se encarga de ordenar los usuarios segun su edad
        /// <author>CMR - 16-01-2024</author>
        /// </summary>
        /// <param name="listaAntigua"></param>
        public void ordenarLista(List<UsuariosDto> listaAntigua);
    }
}

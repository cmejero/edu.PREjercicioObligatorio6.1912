using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.EjercicioObligatorio6._1912.Dtos
{
    /// <summary>
    /// Clase que se encarga de la de los campos de nuestros usuarios.
    /// <author>CMR - 16-01-2024</author>
    /// </summary>
    internal class UsuariosDto
    {
        long idCliente;
        string nombreCliente = "aaaa";
        string apellidosCliente = "aaaa";
        string nombreCompletoCliente = "aaaa";
        int edad = 1;

        public UsuariosDto(long idCliente, string nombreCliente, string apellidosCliente, int edad)
        {
            this.idCliente = idCliente;
            this.nombreCliente = nombreCliente;
            this.apellidosCliente = apellidosCliente;
            this.nombreCompletoCliente = nombreCliente + " " + apellidosCliente;
            this.edad = edad;
        }

        public long IdCliente { get => idCliente; set => idCliente = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string ApellidosCliente { get => apellidosCliente; set => apellidosCliente = value; }
        public string NombreCompletoCliente { get => nombreCompletoCliente; set => nombreCompletoCliente = value; }
        public int Edad { get => edad; set => edad = value; }

        public UsuariosDto()
        {
        }
        override
            public string ToString()
        {
            string usuario = idCliente + " " + nombreCliente + " " + apellidosCliente + " " + edad + " ";
            return usuario;
        }
    }

}

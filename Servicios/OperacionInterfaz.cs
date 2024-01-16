using edu.EjercicioObligatorio6._1912.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.EjercicioObligatorio6._1912.Servicios
{
    internal interface OperacionInterfaz
    {
        public void agregarUsuario(List<UsuariosDto> listaAntigua);

        public void ordenarLista(List<UsuariosDto> listaAntigua);
    }
}

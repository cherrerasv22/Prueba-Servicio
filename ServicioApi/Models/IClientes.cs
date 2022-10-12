
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicioApi.Models
{
    public interface IClientes
    {
        IEnumerable<Clientes> GetClientes();
        IEnumerable<Clientes> GetClientesPorNombreApellido(String nombreapellido);
        IEnumerable<Clientes> GetClientesPorNumeroDocumento(string numerodocumento);
        IEnumerable<Clientes> GetClientesPorNombreDocumento(string nombredocumento);
        IEnumerable<Clientes> GetClientesPorDireccion(string direccion);

    }
}

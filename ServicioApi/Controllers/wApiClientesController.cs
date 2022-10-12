using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServicioApi.Models;

namespace ServicioApi.Controllers
{
    
    [ApiController]
    public class wApiClientesController : ControllerBase
    {
        ClientesServices cli = new ClientesServices();

        [Route("api/Clientes")]
        [HttpGet]
        public IEnumerable<Clientes> Get()
        {

            return cli.GetClientes();
        }



        [Route("api/Clientes/Direccion/{Direccion}")]
        [HttpGet]
        public IEnumerable<Clientes> GetPorDireccion(String direccion)
        {

            return cli.GetClientesPorDireccion(direccion);
        }


        [Route("api/Clientes/NumeroDocumento/{NumeroDocumento}")]
        [HttpGet]
        public IEnumerable<Clientes> GetPorNumeroDocumento(String numerodocumento)
        {

            return cli.GetClientesPorNumeroDocumento(numerodocumento);
        }

        [Route("api/Clientes/NombreApellido/{NombreApellido}")]
        [HttpGet]
        public IEnumerable<Clientes> GetPorNombreApellido(String nombreapellido)
        {

            return cli.GetClientesPorNombreApellido(nombreapellido);
        }


        [Route("api/Clientes/NombreDocumento/{NombreDocumento}")]
        [HttpGet]
        public IEnumerable<Clientes> GetporNombreDocumento(String nombredocumento)
        {

            return cli.GetClientesPorNombreDocumento(nombredocumento);
        }
    }
}

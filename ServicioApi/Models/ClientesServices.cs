using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace ServicioApi.Models
{
    public class ClientesServices : IClientes
    {


        public List<Clientes> DatosClientes()
        {

            return new List<Clientes>
            {
                new Clientes{ 
                    idparticipante =1, Primerapellido = "Roldan", Segundoapellido= "Marroquin" ,Primernombre="Alexandra" ,Segundonombre="Maria",
                    Documentosidentificacions = new List<Documentosidentificacion>{ 
                     new Documentosidentificacion { Codtipoidentificacion=1, Abreviatura="DUI",Numeroidentificacion="00991",Fechavencimiento=DateTime.Now}, 
                     new Documentosidentificacion { Codtipoidentificacion =2, Abreviatura = "NIT", Numeroidentificacion = "0609080810", Fechavencimiento = DateTime.Now } },
                    Direcciones = new List<Direcciones>{ 
                    new Direcciones {tipodireccion=1,detalle="Nejapa" } }
                },

               new Clientes{
                    idparticipante =1, Primerapellido = "Herrera", Segundoapellido= "Garcia" ,Primernombre="Karla" ,Segundonombre="Daniela",
                    Documentosidentificacions = new List<Documentosidentificacion>{
                     new Documentosidentificacion { Codtipoidentificacion=1, Abreviatura="DUI",Numeroidentificacion="222201",Fechavencimiento=DateTime.Now},
                     new Documentosidentificacion { Codtipoidentificacion =2, Abreviatura = "NIT", Numeroidentificacion = "2222203", Fechavencimiento = DateTime.Now } },
                    Direcciones = new List<Direcciones>{
                    new Direcciones {tipodireccion=1,detalle="Santa Ana" } }
                },

                  new Clientes{
                    idparticipante =1, Primerapellido = "Herrera", Segundoapellido= "Retana" ,Primernombre="Rosicela" ,Segundonombre="Fernanda",
                    Documentosidentificacions = new List<Documentosidentificacion>{
                     new Documentosidentificacion { Codtipoidentificacion=1, Abreviatura="DUI",Numeroidentificacion="3333301",Fechavencimiento=DateTime.Now},
                     new Documentosidentificacion { Codtipoidentificacion =2, Abreviatura = "NIT", Numeroidentificacion = "33333302", Fechavencimiento = DateTime.Now } },
                    Direcciones = new List<Direcciones>{
                    new Direcciones {tipodireccion=1,detalle="ChalChuapa" } }
                },

                     new Clientes{
                    idparticipante =1, Primerapellido = "Herrera", Segundoapellido= "Garcia" ,Primernombre="Sara" ,Segundonombre="Gabriela",
                    Documentosidentificacions = new List<Documentosidentificacion>{
                     new Documentosidentificacion { Codtipoidentificacion=1, Abreviatura="DUI",Numeroidentificacion="444401",Fechavencimiento=DateTime.Now},
                     new Documentosidentificacion { Codtipoidentificacion =2, Abreviatura = "NIT", Numeroidentificacion = "444402", Fechavencimiento = DateTime.Now } },
                    Direcciones = new List<Direcciones>{
                    new Direcciones {tipodireccion=1,detalle="Ahuachapan" } }
                },

                        new Clientes{
                    idparticipante =1, Primerapellido = "Herrera", Segundoapellido= "Leiva" ,Primernombre="Alejandra" ,Segundonombre="Maria",
                    Documentosidentificacions = new List<Documentosidentificacion>{
                     new Documentosidentificacion { Codtipoidentificacion=1, Abreviatura="DUI",Numeroidentificacion="5555501",Fechavencimiento=DateTime.Now},
                     new Documentosidentificacion { Codtipoidentificacion =2, Abreviatura = "NIT", Numeroidentificacion = "5555502", Fechavencimiento = DateTime.Now } },
                    Direcciones = new List<Direcciones>{
                    new Direcciones {tipodireccion=1,detalle="Sonsonate" } }
                },

            };

        }


      public  IEnumerable<Clientes> GetClientes()
        {
            return DatosClientes();
        }

        public IEnumerable<Clientes> GetClientesPorDireccion(string direccion)
        {
            var filtered = DatosClientes()
           .Where(o => o.Direcciones.Any(d => d.detalle == direccion)).ToList();
            // .Select(o => new { Order = o, Details = o.Detail.Where(d => d.StockCode == "STK2") });

            return filtered ;
        }

        public IEnumerable<Clientes> GetClientesPorNombreApellido(string nombreapellido)
        {
            return DatosClientes().Where(d=> d.Primerapellido.Contains(nombreapellido) || d.Segundoapellido.Contains(nombreapellido) || d.Primernombre.Contains(nombreapellido) || d.Segundonombre.Contains(nombreapellido));
        }

        public IEnumerable<Clientes> GetClientesPorNombreDocumento(string nombredocumento)
        {
            var filtered = DatosClientes()
          .Where(o => o.Documentosidentificacions.Any(d => d.Abreviatura == nombredocumento)).ToList();
            // .Select(o => new { Order = o, Details = o.Detail.Where(d => d.StockCode == "STK2") });

            return filtered;
        }

        public IEnumerable<Clientes> GetClientesPorNumeroDocumento(string numerodocumento)
        {
            var filtered = DatosClientes()
          .Where(o => o.Documentosidentificacions.Any(d => d.Numeroidentificacion == numerodocumento)).ToList();
            // .Select(o => new { Order = o, Details = o.Detail.Where(d => d.StockCode == "STK2") });

            return filtered;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ServicioApi.Models;

namespace ServicioApi.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            List<Clientes> ListadoClientes = new List<Clientes>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44378/api/Clientes"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    ListadoClientes = JsonConvert.DeserializeObject<List<Clientes>>(apiResponse);
                }
            }
            return View(ListadoClientes);
        }


        [HttpPost]
        public async Task<IActionResult> Index(string txtNombre, string txtnumerodocumento,string txtdireccion,string txtnombredocumento)
        {
            string ur = "https://localhost:44378/api/Clientes";
            if (txtNombre != string.Empty)
            {
               ur= "https://localhost:44378/api/Clientes/NombreApellido/" + txtNombre;
            }
            else if(txtnumerodocumento!=string.Empty)
            {
                ur = "https://localhost:44378/api/Clientes/NumeroDocumento/" + txtnumerodocumento;
            }
            else if (txtnombredocumento != string.Empty)
            {
                ur = "https://localhost:44378/api/Clientes/NombreDocumento/" + txtnombredocumento;
            }
            else if (txtdireccion != string.Empty)
            {
                ur = "https://localhost:44378/api/Clientes/Direccion/" + txtdireccion;
            }

            List<Clientes> ListadoClientes = new List<Clientes>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(ur))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    ListadoClientes = JsonConvert.DeserializeObject<List<Clientes>>(apiResponse);
                }
            }
            return View(ListadoClientes);
        }
    }
}

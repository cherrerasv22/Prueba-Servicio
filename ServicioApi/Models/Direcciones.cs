using System.ComponentModel.DataAnnotations;

namespace ServicioApi.Models
{
    public class Direcciones
    {
        public int tipodireccion { get; set; }
        //[Required]
        public string detalle { get; set; }
    
    }
}

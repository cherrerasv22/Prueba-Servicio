using System;
using System.ComponentModel.DataAnnotations;

namespace ServicioApi.Models
{
    public class Documentosidentificacion
    {
        public int Codtipoidentificacion { get; set; }
        //[Required]
        public string Abreviatura { get; set; }
        //[Required]
        public string Numeroidentificacion { get; set; }
        //[Required]
        public DateTime Fechavencimiento { get; set; }
       // [Required]
       // [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$")]
    
    }
}

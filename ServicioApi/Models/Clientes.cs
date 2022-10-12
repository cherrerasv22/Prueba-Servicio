using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ServicioApi.Models
{
    public class Clientes
    {
        public int idparticipante { get; set; }
        //[Required]
        public string Primerapellido { get; set; }
        //[Required]
        public string Segundoapellido { get; set; }
        //[Required]
        public string Primernombre { get; set; }
        // [Required]
        // [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$")]
        public string Segundonombre { get; set; }

        public virtual List<Documentosidentificacion> Documentosidentificacions { get; set; }

        public virtual List<Direcciones> Direcciones { get; set; }
    }
}

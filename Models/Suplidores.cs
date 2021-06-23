using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RegistroPedidos_Blazord.Models
{
    public class Suplidores
    {
        [Key]
        public int SuplidorId { get; set; }

        [Required(ErrorMessage = "Inserte el nombre del suplidor")]
        public string Nombres { get; set; }

        public ICollection<Ordenes> Ordenes { get; set; }

    }
}

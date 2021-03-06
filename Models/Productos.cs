using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RegistroPedidos_Blazord.Models
{
    public class Productos
    {
        [Key]
        public int ProductoId { get; set; }

        [Required(ErrorMessage = "Inserte la descripción del producto")]
        public string  Descripcion { get; set; }

        [Range(minimum: 0.0, maximum: 50000000.0, ErrorMessage = "Inserte costo válido")]
        public float Costo  { get; set; }

        public float Inventario { get; set; }

        public ICollection<OrdenesDetalle> OrdenesDetalle { get; set; }
    }
}

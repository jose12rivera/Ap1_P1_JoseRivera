using System.ComponentModel.DataAnnotations;

namespace Ap1_P1_JoseRivera.Models
{
    public class Articulos
    {
        [Key]
        public int ArticuloId { get; set; }
        [Required(ErrorMessage ="por favor ingrese la descripcion")]
        public string? Descripcion { get; set; }
        [Required(ErrorMessage = "por favor ingrese la ganacia")]
        public decimal? Ganancia { get; set; }
        [Required(ErrorMessage = "por favor ingrese el costo")]
        public decimal? Costo { get; set; }
        [Required(ErrorMessage = "por favor ingrese el precio")]
        public decimal? Precio { get; set; }
    }
}

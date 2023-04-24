using System.ComponentModel.DataAnnotations;

namespace GG_Examen.Models
{
    public class GGuevara
    {
        public int gg_codigo { get; set; }
        [Required]
        public string? gg_nombre { get; set; }
        public bool gg_EnStock { get; set; }

        [Range(0.01, 9999.99)]
        public decimal gg_Precio { get; set; }

    
    }
}

using System.ComponentModel.DataAnnotations;

namespace GG_Examen.Models
{
    public class GGuevara
    {
        public int gg_Codigo { get; set; }
        [Required]
        [StringLength(15)]
        public string? gg_Nombre { get; set; }
        public bool gg_EnStock { get; set; }

        [Range(0.01, 9999.99)]
        [RegularExpression(@"^\$?\d+(\.(\d{2}))?$")]
        public decimal gg_Precio { get; set; }

        public DateTime gg_FechaCaducidad { get; set; }

        [EmailAddress]
        public string? gg_CorreoClienteQueAdquirioProducto { get; set; }

    }
}

using System.ComponentModel.DataAnnotations;

namespace AgendaContatosMVC.Models
{
    public class Contato
    {
        public int Id { get; set; }

        [Required]
        public string? Nome { get; set; }

        [Required]
        [Phone]
        public string? Telefone { get; set; }    

        [EmailAddress]
        public string? Email { get; set; }
    }
}

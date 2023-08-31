using System.ComponentModel.DataAnnotations;

namespace Marketplace.mvc.Models
{
    public class ClienteViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Documento { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Telefone { get; set; }
        [Required]
        public string Email { get; set; }   
    }
}

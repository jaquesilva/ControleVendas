using NuGet.Protocol.Core.Types;
using System.ComponentModel.DataAnnotations;

namespace ControleVendas.Models
{
    public class Login
    {
        public int? LoginID { get; set; }

        [Display(Name = "E-mail")]
        [Required]
        public string? Email { get; set; }

        public string? Senha { get; set; }

    }
}

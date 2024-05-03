using System.ComponentModel.DataAnnotations;

namespace ControleVendas.Models
{
    public class Colaborador
    {
        public int ColaboradorID { get; set; }

        [Display(Name = "Nível de Acesso")]
        public int NivelAcessoID { get; set; } = 2;

        public string? Nome { get; set; }

        [Display(Name = "CPF")]
        public string? Cpf { get; set; }

        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "O campo de e-mail é obrigatório.")]
        [EmailAddress(ErrorMessage = "Insira um endereço de e-mail válido.")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "A senha é obrigatória.")]
        [StringLength(10, MinimumLength = 6, ErrorMessage = "Máximo de 10, mínimo de 6 caracteres")]
        [DataType(DataType.Password)]
        public string? Senha { get; set; }

        public string? Telefone { get; set; }

        public string? Cargo { get; set; }
    }
}

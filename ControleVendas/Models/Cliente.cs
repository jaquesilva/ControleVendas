using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControleVendas.Models
{
    public class Cliente
    {
        public int ClienteID { get; set; }

        [Display(Name = "Nível de Acesso")]
        public int NivelAcessoID { get; set; } = 3;

        public string? Nome { get; set; }

        [Display(Name = "CPF")]
        public string? Cpf { get; set; }

        [Display(Name = "E-mail")]
        public string? Email { get; set; }

        [StringLength(10, MinimumLength = 6, ErrorMessage = "Máximo de 10, mínimo de 6 caracteres")]
        public string? Senha { get; set; }

        public string? Telefone { get; set; }

        [Display(Name = "Endereço")]
        public string? Endereco { get; set; }

        [Display(Name = "Data do Cadastro")]
        public DateTime DataCadastro { get; set; }

    }
}

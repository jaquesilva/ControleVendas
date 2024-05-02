using System.ComponentModel.DataAnnotations;

namespace ControleVendas.Models
{
    public class Cliente
    {
        public int ClienteID { get; set; }

        public int NivelAcessoID { get; set; } = 3;

        public string? Nome { get; set; }

        [Display(Name = "CPF")]
        public string? Cpf { get; set; }

        [Display(Name = "E-mail")]
        public string? Email { get; set; }

        public string? Telefone { get; set; }

        [Display(Name = "Endereço")]
        public string? Endereco { get; set; }

        [Display(Name = "Data Cadastro")]
        public DateTime DataCadastro { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace ControleVendas.Models
{
    public class Venda
    {
        public int? VendaID { get; set; }

        public int Produto { get; set; }

        [Display(Name = "Descrição")]
        public string? Descricao { get; set; }

        public int Quantidade { get; set; }

        [Display(Name = "Valor Unitário")]
        public decimal ValorUnitario { get; set; }

        [Display(Name = "Valor Total")]
        public decimal ValorTotal { get; set; }

        [Display(Name = "Cliente")]
        public int ClienteID { get; set; }

        [Display(Name = "Colaborador")]
        public int ColaboradorID { get; set; }
    }
}

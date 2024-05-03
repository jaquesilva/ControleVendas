using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;

namespace ControleVendas.Models
{
    public class Produto
    {
        public int? ProdutoID { get; set; }

        [Display(Name = "Produto")]
        public string? NomeProduto{ get; set; }

        [Display(Name = "Descrição")]
        public string? Descricao { get; set; }

        [Display(Name = "Custo Unitário")]
        public decimal  CustoUnitario { get; set; }

        [Display(Name = "Preço de Venda")]
        public decimal PrecoVenda { get; set; }

        public string? Fornecedor { get; set; }
    }
}

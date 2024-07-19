using System.ComponentModel.DataAnnotations;

namespace NerdStore.Catalogo.Application.ViewModels
{
    public class ProdutoViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo {0} e obrigatorio")]
        public Guid CategoriaId { get; set; }

        [Required(ErrorMessage = "O campo {0} e obrigatorio")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} e obrigatorio")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O campo {0} e obrigatorio")]
        public bool Ativo { get; set; }

        [Required(ErrorMessage = "O campo {0} e obrigatorio")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "O campo {0} e obrigatorio")]
        public DateTime DataCadastro { get; set; }

        [Required(ErrorMessage = "O campo {0} e obrigatorio")]
        public string Imagem { get; set; }

        [Required(ErrorMessage = "O campo {0} e obrigatorio")]
        [Range(1, int.MaxValue, ErrorMessage = "O campo {0} precisa ter o valor minimo de {1}")]
        public int QuantidadeEstoque { get; set; }

        [Required(ErrorMessage = "O campo {0} e obrigatorio")]
        [Range(1, int.MaxValue, ErrorMessage = "O campo {0} precisa ter o valor minimo de {1}")]
        public int Altura { get; set; }

        [Required(ErrorMessage = "O campo {0} e obrigatorio")]
        [Range(1, int.MaxValue, ErrorMessage = "O campo {0} precisa ter o valor minimo de {1}")]
        public int Largura { get; set; }

        [Required(ErrorMessage = "O campo {0} e obrigatorio")]
        [Range(1, int.MaxValue, ErrorMessage = "O campo {0} precisa ter o valor minimo de {1}")]
        public int Profundidade { get; set; }

        public IEnumerable<CategoriaViewModel> Categorias { get; set; }
    }
}

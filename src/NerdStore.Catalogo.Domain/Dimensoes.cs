using NerdStore.Core.DomainObjects;

namespace NerdStore.Catalogo.Domain
{
    public class Dimensoes
    {
        public decimal Altura { get; set; }
        public decimal Largura { get; set; }
        public decimal Profundidade { get; set; }

        public Dimensoes(decimal altura, decimal largura, decimal profundidade)
        {
            Validacoes.ValidarSerMenorQue(altura, 1, "O campo Altura tem que ser no minimo 1");
            Validacoes.ValidarSerMenorQue(largura, 1, "O campo Largura tem que ser no minimo 1");
            Validacoes.ValidarSerMenorQue(profundidade, 1, "O campo Profundidade tem no ser no minimo 1");

            Altura = altura;
            Largura = largura;
            Profundidade = profundidade;
        }

        public string DescricaoFormatada()
        {
            return $"LxAxP: {Largura} x {Altura} x {Profundidade}";
        }

        public override string ToString()
        {
            return DescricaoFormatada();
        }
    }
}

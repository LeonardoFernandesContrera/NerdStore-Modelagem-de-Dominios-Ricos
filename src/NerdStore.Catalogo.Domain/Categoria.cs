using NerdStore.Core.DomainObjects;

namespace NerdStore.Catalogo.Domain
{
    public class Categoria : Entity
    {
        public string Nome { get; private set; }
        public int Codigo { get; private set; }

        // Relacao do Entity Framework
        public ICollection<Produto> Produtos { get; set; }

        protected Categoria() {}

        public Categoria(string nome, int codigo)
        {
            Nome = nome;
            Codigo = codigo;

            Validar();
        }

        public override string ToString()
        {
            return $"{Nome} - {Codigo}";
        }

        public void Validar()
        {
            Validacoes.ValidarSeVazio(Nome, "O campo Nome da categoria nao pode estar vazio");
            Validacoes.ValidarSerIgual(Codigo, 0, "O campo Codigo nao pode ser 0");
        }
    }
}

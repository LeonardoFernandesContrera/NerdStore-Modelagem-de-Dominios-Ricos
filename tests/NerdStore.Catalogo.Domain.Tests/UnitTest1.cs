using NerdStore.Core.DomainObjects;
using Xunit;

namespace NerdStore.Catalogo.Domain.Tests
{
    public class ProdutoTests
    {
        [Fact]
        public void Produto_Validar_ValidacoesDevemRetornarExceptions()
        {
            // Arange & Act & Assert

            var ex = Assert.Throws<DomainException>(() => 
                    new Produto(string.Empty, "Descricao", false, 100, Guid.NewGuid()))
        }
    }
}
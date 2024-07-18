using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NerdStore.Catalogo.Domain;

namespace NerdStore.Catalogo.Data.Mappings
{
    public class ProdutoMapping : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(prod => prod.Id);

            builder.Property(prod => prod.Nome)
               .IsRequired()
               .HasColumnType("varchar(250)");

            builder.Property(prod => prod.Descricao)
               .IsRequired()
               .HasColumnType("varchar(500)");

            builder.Property(prod => prod.Imagem)
               .IsRequired()
               .HasColumnType("varchar(250)");

            builder.OwnsOne(prod => prod.Dimensoes, cm =>
            {
                cm.Property(c => c.Altura)
                .HasColumnName("Altura")
                .HasColumnType("int");

                cm.Property(c => c.Largura)
                .HasColumnName("Largura")
                .HasColumnType("int");

                cm.Property(c => c.Profundidade)
               .HasColumnName("Profundidade")
               .HasColumnType("int");
            });

            builder.ToTable("Produtos");
        }
    }
}

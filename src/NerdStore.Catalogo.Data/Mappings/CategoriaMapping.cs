using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NerdStore.Catalogo.Domain;

namespace NerdStore.Catalogo.Data.Mappings
{
    public class CategoriaMapping : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.HasKey(cat => cat.Id);

            builder.Property(cat => cat.Nome)
                .IsRequired()
                .HasColumnType("varchar(250)");

            //1 : N => Categorias : Produtos

            builder.HasMany(cat => cat.Produtos)
                .WithOne(prod => prod.Categoria)
                .HasForeignKey(prod => prod.CategoriaId);

            builder.ToTable("Categorias");
        }
    }
}

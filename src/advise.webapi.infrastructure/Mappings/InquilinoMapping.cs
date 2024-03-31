using advise.webapi.core.Models;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace advise.webapi.infrastructure.Mappings
{
    public class InquilinoMapping : IEntityTypeConfiguration<Inquilino>
    {
        public void Configure(EntityTypeBuilder<Inquilino> builder)
        {
            // Filtro para não trazer os Deletados
            builder
                .HasQueryFilter(e => !e.Deletado);

            // Chave primária
            builder
                .HasKey(inquilino => inquilino.Id);

            // Mapeamento das propriedades
            builder
                .Property(inquilino => inquilino.Nome)
                .HasMaxLength(100)
                .IsRequired();
            builder
                .Property(inquilino => inquilino.Telefone)
                .HasMaxLength(20)
                .IsRequired();
            builder
                .Property(inquilino => inquilino.Status)
                .IsRequired();

            // Relacionamentos
            builder
                .HasMany(inquilino => inquilino.AtendimentosCorretores)
                .WithOne(contato => contato.Inquilino)
                .HasForeignKey(contato => contato.InquilinoId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany(inquilino => inquilino.Locacoes)
                .WithOne(locacao => locacao.Inquilino)
                .HasForeignKey(locacao => locacao.InquilinoId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.ToTable("Inquilinos");

            builder.HasData(GetData());
        }

        private IEnumerable<Inquilino> GetData()
        {
            return new List<Inquilino>
        {
            new Inquilino
            {
                Id = Guid.Parse("00000000-0000-0000-0000-000000000011"),
                Nome = "José Pereira",
                Telefone = "111111111",
                Status = true,
                DataCriacao = DateTime.Now
            },
            new Inquilino
            {
                Id = Guid.Parse("00000000-0000-0000-0000-000000000012"),
                Nome = "Ana Paula",
                Telefone = "222222222",
                Status = true,
                DataCriacao = DateTime.Now
            },
            new Inquilino
            {
                Id = Guid.Parse("00000000-0000-0000-0000-000000000013"),
                Nome = "Luiz Santos",
                Telefone = "333333333",
                Status = true,
                DataCriacao = DateTime.Now
            },
            new Inquilino
            {
                Id = Guid.Parse("00000000-0000-0000-0000-000000000014"),
                Nome = "Mariana Oliveira",
                Telefone = "444444444",
                Status = true,
                DataCriacao = DateTime.Now
            },
            new Inquilino
            {
                Id = Guid.Parse("00000000-0000-0000-0000-000000000015"),
                Nome = "Pedro Henrique",
                Telefone = "555555555",
                Status = true,
                DataCriacao = DateTime.Now
            },
            new Inquilino
            {
                Id = Guid.Parse("00000000-0000-0000-0000-000000000016"),
                Nome = "Carla Silva",
                Telefone = "666666666",
                Status = true,
                DataCriacao = DateTime.Now
            },
            new Inquilino
            {
                Id = Guid.Parse("00000000-0000-0000-0000-000000000017"),
                Nome = "Rafaela Lima",
                Telefone = "777777777",
                Status = true,
                DataCriacao = DateTime.Now
            },
            new Inquilino
            {
                Id = Guid.Parse("00000000-0000-0000-0000-000000000018"),
                Nome = "Gustavo Costa",
                Telefone = "888888888",
                Status = true,
                DataCriacao = DateTime.Now
            },
            new Inquilino
            {
                Id = Guid.Parse("00000000-0000-0000-0000-000000000019"),
                Nome = "Fernanda Souza",
                Telefone = "999999999",
                Status = true,
                DataCriacao = DateTime.Now
            },
            new Inquilino
            {
                Id = Guid.Parse("00000000-0000-0000-0000-000000000020"),
                Nome = "Lucas Martins",
                Telefone = "000000000",
                Status = true,
                DataCriacao = DateTime.Now
            }
        };
        }
    }

}

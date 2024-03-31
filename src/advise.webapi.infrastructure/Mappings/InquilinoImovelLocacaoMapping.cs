using advise.webapi.core.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace advise.webapi.infrastructure.Mappings
{
    public class InquilinoImovelLocacaoMapping : IEntityTypeConfiguration<InquilinoImovelLocacao>
    {
        public void Configure(EntityTypeBuilder<InquilinoImovelLocacao> builder)
        {
            // Chave primária
            builder
                .HasKey(locacao => locacao.Id);

            // Mapeamento das propriedades
            builder
                .Property(locacao => locacao.DataEntrada)
                .IsRequired();
            builder
                .Property(locacao => locacao.AtendimentoCorretorId)
                .IsRequired();
            builder
                .Property(locacao => locacao.InquilinoId)
                .IsRequired();
            builder
                .Property(locacao => locacao.ImovelId)
                .IsRequired();

            // Relacionamentos
            builder
                .HasOne(locacao => locacao.AtendimentoCorretor)
                .WithOne()
                .HasForeignKey<InquilinoImovelLocacao>(locacao => locacao.AtendimentoCorretorId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);


            builder
                .HasOne(locacao => locacao.Inquilino)
                .WithMany(inquilino => inquilino.Locacoes)
                .HasForeignKey(locacao => locacao.InquilinoId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(locacao => locacao.Imovel)
                .WithMany(imovel => imovel.Locacoes)
                .HasForeignKey(locacao => locacao.ImovelId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.ToTable("InquilinoImovelLocacoes");

            builder.HasData(GetInquilinoImovelLocacao());
        }

        private IEnumerable<InquilinoImovelLocacao> GetInquilinoImovelLocacao()
        {
            return new List<InquilinoImovelLocacao>
            {
                new InquilinoImovelLocacao
                {
                    DataEntrada = DateTime.Parse("2024-03-31T18:52:53.078Z"),
                    DataSaida = DateTime.Parse("2024-03-31T18:52:53.078Z"),
                    InquilinoId = Guid.Parse("00000000-0000-0000-0000-000000000011"),
                    ImovelId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    AtendimentoCorretorId = Guid.Parse("00000000-0000-0000-0000-000000000001")
                },
                new InquilinoImovelLocacao
                {
                    DataEntrada = DateTime.Parse("2024-03-31T18:52:53.078Z"),
                    DataSaida = DateTime.Parse("2024-03-31T18:52:53.078Z"),
                    InquilinoId = Guid.Parse("00000000-0000-0000-0000-000000000012"),
                    ImovelId = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    AtendimentoCorretorId = Guid.Parse("00000000-0000-0000-0000-000000000002")
                },
                new InquilinoImovelLocacao
                {
                    DataEntrada = DateTime.Parse("2024-03-31T18:52:53.078Z"),
                    DataSaida = DateTime.Parse("2024-03-31T18:52:53.078Z"),
                    InquilinoId = Guid.Parse("00000000-0000-0000-0000-000000000013"),
                    ImovelId = Guid.Parse("00000000-0000-0000-0000-000000000003"),
                    AtendimentoCorretorId = Guid.Parse("00000000-0000-0000-0000-000000000003")
                },
                new InquilinoImovelLocacao
                {
                    DataEntrada = DateTime.Parse("2024-03-31T18:52:53.078Z"),
                    DataSaida = DateTime.Parse("2024-03-31T18:52:53.078Z"),
                    InquilinoId = Guid.Parse("00000000-0000-0000-0000-000000000014"),
                    ImovelId = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                    AtendimentoCorretorId = Guid.Parse("00000000-0000-0000-0000-000000000004")
                },
                new InquilinoImovelLocacao
                {
                    DataEntrada = DateTime.Parse("2024-03-31T18:52:53.078Z"),
                    DataSaida = DateTime.Parse("2024-03-31T18:52:53.078Z"),
                    InquilinoId = Guid.Parse("00000000-0000-0000-0000-000000000015"),
                    ImovelId = Guid.Parse("00000000-0000-0000-0000-000000000005"),
                    AtendimentoCorretorId = Guid.Parse("00000000-0000-0000-0000-000000000005")
                },
                new InquilinoImovelLocacao
                {
                    DataEntrada = DateTime.Parse("2024-03-31T18:52:53.078Z"),
                    DataSaida = DateTime.Parse("2024-03-31T18:52:53.078Z"),
                    InquilinoId = Guid.Parse("00000000-0000-0000-0000-000000000016"),
                    ImovelId = Guid.Parse("00000000-0000-0000-0000-000000000006"),
                    AtendimentoCorretorId = Guid.Parse("00000000-0000-0000-0000-000000000006")
                }
            };
        }

    }
}

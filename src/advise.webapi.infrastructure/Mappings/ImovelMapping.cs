using advise.webapi.core.Models;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace advise.webapi.infrastructure.Mappings
{
    public class ImovelMapping : IEntityTypeConfiguration<Imovel>
    {
        public void Configure(EntityTypeBuilder<Imovel> builder)
        {
            // Chave primária
            builder
                .HasKey(imovel => imovel.Id);

            // Mapeamento das propriedades
            builder
                .Property(imovel => imovel.QtdeQuartos)
                .IsRequired();
            builder
                .Property(imovel => imovel.QtdeBanheiros)
                .IsRequired();
            builder
                .Property(imovel => imovel.QtdeVagasGaragem)
                .IsRequired();
            builder
                .Property(imovel => imovel.TipoImovel)
                .IsRequired();
            builder
                .Property(imovel => imovel.PosicaoSolar)
                .IsRequired();
            builder
                .Property(imovel => imovel.Valor)
                .HasColumnType("decimal(18,2)")
                .IsRequired();
            builder
                .Property(imovel => imovel.Observacoes)
                .HasMaxLength(500);
            builder
                .Property(imovel => imovel.Status)
                .IsRequired();
            builder
                .Property(imovel => imovel.ProprietarioId)
                .IsRequired();

            // Relacionamentos
            builder
                .HasOne(imovel => imovel.Endereco)
                .WithOne(end => end.Imovel)
                .HasForeignKey<Endereco>(e => e.ImovelId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasOne(imovel => imovel.Proprietario)
                .WithMany(proprietario => proprietario.Imoveis)
                .HasForeignKey(imovel => imovel.ProprietarioId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany(imovel => imovel.Locacoes)
                .WithOne(locacao => locacao.Imovel)
                .HasForeignKey(locacao => locacao.ImovelId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.ToTable("Imoveis");

            builder.HasData(GetImoveis());
        }

        private IEnumerable<Imovel> GetImoveis()
        {
            return new List<Imovel>
            {
                new Imovel
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    QtdeQuartos = 2,
                    QtdeBanheiros = 1,
                    QtdeVagasGaragem = 1,
                    TipoImovel = TipoImovel.Apartamento,
                    PosicaoSolar = PosicaoSolar.Sul,
                    Valor = 200000,
                    Observacoes = "Apartamento compacto no centro da cidade.",
                    Status = true,
                    ProprietarioId = Guid.Parse("00000000-0000-0000-0000-000000000022"),
                    DataCriacao = DateTime.Now
                },
                new Imovel
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    QtdeQuartos = 3,
                    QtdeBanheiros = 2,
                    QtdeVagasGaragem = 2,
                    TipoImovel = TipoImovel.Casa,
                    PosicaoSolar = PosicaoSolar.Norte,
                    Valor = 350000,
                    Observacoes = "Casa com acabamento de alto padrão.",
                    Status = true,
                    ProprietarioId = Guid.Parse("00000000-0000-0000-0000-000000000023"),
                    DataCriacao = DateTime.Now
                },
                new Imovel
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000003"),
                    QtdeQuartos = 4,
                    QtdeBanheiros = 3,
                    QtdeVagasGaragem = 2,
                    TipoImovel = TipoImovel.Casa,
                    PosicaoSolar = PosicaoSolar.Leste,
                    Valor = 400000,
                    Observacoes = "Casa espaçosa com área de lazer.",
                    Status = true,
                    ProprietarioId = Guid.Parse("00000000-0000-0000-0000-000000000024"),
                    DataCriacao = DateTime.Now
                },
                new Imovel
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                    QtdeQuartos = 1,
                    QtdeBanheiros = 1,
                    QtdeVagasGaragem = 0,
                    TipoImovel = TipoImovel.Apartamento,
                    PosicaoSolar = PosicaoSolar.Oeste,
                    Valor = 150000,
                    Observacoes = "Apartamento simples próximo ao metrô.",
                    Status = true,
                    ProprietarioId = Guid.Parse("00000000-0000-0000-0000-000000000025"),
                    DataCriacao = DateTime.Now
                },
                new Imovel
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000005"),
                    QtdeQuartos = 3,
                    QtdeBanheiros = 2,
                    QtdeVagasGaragem = 2,
                    TipoImovel = TipoImovel.Casa,
                    PosicaoSolar = PosicaoSolar.Norte,
                    Valor = 300000,
                    Observacoes = "Casa aconchegante em condomínio fechado.",
                    Status = true,
                    ProprietarioId = Guid.Parse("00000000-0000-0000-0000-000000000026"),
                    DataCriacao = DateTime.Now
                },
                new Imovel
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000006"),
                    QtdeQuartos = 2,
                    QtdeBanheiros = 1,
                    QtdeVagasGaragem = 1,
                    TipoImovel = TipoImovel.Apartamento,
                    PosicaoSolar = PosicaoSolar.Sul,
                    Valor = 180000,
                    Observacoes = "Apartamento bem localizado próximo a comércios.",
                    Status = true,
                    ProprietarioId = Guid.Parse("00000000-0000-0000-0000-000000000027"),
                    DataCriacao = DateTime.Now
                },
                new Imovel
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000007"),
                    QtdeQuartos = 4,
                    QtdeBanheiros = 3,
                    QtdeVagasGaragem = 2,
                    TipoImovel = TipoImovel.Casa,
                    PosicaoSolar = PosicaoSolar.Oeste,
                    Valor = 400000,
                    Observacoes = "Casa ampla em condomínio fechado.",
                    Status = true,
                    ProprietarioId = Guid.Parse("00000000-0000-0000-0000-000000000028"),
                    DataCriacao = DateTime.Now
                },
                new Imovel
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000008"),
                    QtdeQuartos = 2,
                    QtdeBanheiros = 1,
                    QtdeVagasGaragem = 1,
                    TipoImovel = TipoImovel.Apartamento,
                    PosicaoSolar = PosicaoSolar.Sul,
                    Valor = 180000,
                    Observacoes = "Apartamento próximo ao parque.",
                    Status = true,
                    ProprietarioId = Guid.Parse("00000000-0000-0000-0000-000000000029"),
                    DataCriacao = DateTime.Now
                },
                new Imovel
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000009"),
                    QtdeQuartos = 2,
                    QtdeBanheiros = 1,
                    QtdeVagasGaragem = 1,
                    TipoImovel = TipoImovel.Apartamento,
                    PosicaoSolar = PosicaoSolar.Norte,
                    Valor = 210000,
                    Observacoes = "Apartamento com ótima vista.",
                    Status = true,
                    ProprietarioId = Guid.Parse("00000000-0000-0000-0000-000000000030"),
                    DataCriacao = DateTime.Now
                },
                new Imovel
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000010"),
                    QtdeQuartos = 3,
                    QtdeBanheiros = 2,
                    QtdeVagasGaragem = 2,
                    TipoImovel = TipoImovel.Casa,
                    PosicaoSolar = PosicaoSolar.Leste,
                    Valor = 350000,
                    Observacoes = "Casa com acabamento de alto padrão.",
                    Status = true,
                    ProprietarioId = Guid.Parse("00000000-0000-0000-0000-000000000021"),
                    DataCriacao = DateTime.Now
                }
            };
        }

    }
}

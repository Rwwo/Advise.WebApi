using advise.webapi.core.Models;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace advise.webapi.infrastructure.Mappings
{
    public class CorretorProprietarioContatosMapping : IEntityTypeConfiguration<CorretorProprietarioContatos>
    {
        public void Configure(EntityTypeBuilder<CorretorProprietarioContatos> builder)
        {

            // Chave primária
            builder.HasKey(contato => contato.Id);

            // Mapeamento das propriedades
            builder
                .Property(contato => contato.DescricaoContato)
                .HasMaxLength(200)
                .IsRequired();
            builder
                .Property(contato => contato.ProprietarioId)
                .IsRequired();
            builder
                .Property(contato => contato.CorretorId)
                .IsRequired();

            // Relacionamentos
            builder
                .HasOne(contato => contato.Proprietario)
                .WithMany(proprietario => proprietario.ContatosCorretores)
                .HasForeignKey(contato => contato.ProprietarioId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(contato => contato.Corretor)
                .WithMany(corretor => corretor.ContatosProprietarios)
                .HasForeignKey(contato => contato.CorretorId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.ToTable("CorretorProprietarioContatos");

            builder.HasData(GetCorretorProprietarioContatos());
        }

        private IEnumerable<CorretorProprietarioContatos> GetCorretorProprietarioContatos()
        {
            return new List<CorretorProprietarioContatos>
            {
                new CorretorProprietarioContatos
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    DescricaoContato = "Solicitação de autorização para reparos no imóvel",
                    CorretorId = Guid.Parse("00000000-0000-0000-0000-000000000007"),
                    ProprietarioId = Guid.Parse("00000000-0000-0000-0000-000000000028"),
                    DataCriacao = DateTime.Now
                },
                new CorretorProprietarioContatos
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    DescricaoContato = "Atualização sobre visitas ao imóvel para venda",
                    CorretorId = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    ProprietarioId = Guid.Parse("00000000-0000-0000-0000-000000000023"),
                    DataCriacao = DateTime.Now
                },
                new CorretorProprietarioContatos
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000003"),
                    DescricaoContato = "Informações sobre propostas de aluguel recebidas",
                    CorretorId = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                    ProprietarioId = Guid.Parse("00000000-0000-0000-0000-000000000025"),
                    DataCriacao = DateTime.Now
                },
                new CorretorProprietarioContatos
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                    DescricaoContato = "Negociação de comissão sobre venda de imóvel",
                    CorretorId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    ProprietarioId = Guid.Parse("00000000-0000-0000-0000-000000000022"),
                    DataCriacao = DateTime.Now
                },
                new CorretorProprietarioContatos
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000005"),
                    DescricaoContato = "Solicitação de documentos para declaração de imposto de renda",
                    CorretorId = Guid.Parse("00000000-0000-0000-0000-000000000009"),
                    ProprietarioId = Guid.Parse("00000000-0000-0000-0000-000000000030"),
                    DataCriacao = DateTime.Now
                },
                new CorretorProprietarioContatos
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000006"),
                    DescricaoContato = "Agendamento de reunião para revisão de contrato de locação",
                    CorretorId = Guid.Parse("00000000-0000-0000-0000-000000000005"),
                    ProprietarioId = Guid.Parse("00000000-0000-0000-0000-000000000026"),
                    DataCriacao = DateTime.Now
                },
                new CorretorProprietarioContatos
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000007"),
                    DescricaoContato = "Confirmação de pagamento de aluguel",
                    CorretorId = Guid.Parse("00000000-0000-0000-0000-000000000008"),
                    ProprietarioId = Guid.Parse("00000000-0000-0000-0000-000000000029"),
                    DataCriacao = DateTime.Now
                },
                new CorretorProprietarioContatos
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000008"),
                    DescricaoContato = "Feedback sobre interessados em compra de imóvel",
                    CorretorId = Guid.Parse("00000000-0000-0000-0000-000000000006"),
                    ProprietarioId = Guid.Parse("00000000-0000-0000-0000-000000000027"),
                    DataCriacao = DateTime.Now
                },
                new CorretorProprietarioContatos
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000009"),
                    DescricaoContato = "Discussão sobre estratégias de marketing para aluguel",
                    CorretorId = Guid.Parse("00000000-0000-0000-0000-000000000003"),
                    ProprietarioId = Guid.Parse("00000000-0000-0000-0000-000000000024"),
                    DataCriacao = DateTime.Now
                }
            };
        }

    }
}

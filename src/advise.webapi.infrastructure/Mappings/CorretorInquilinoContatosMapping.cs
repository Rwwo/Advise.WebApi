using advise.webapi.core.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace advise.webapi.infrastructure.Mappings
{
    public class CorretorInquilinoContatosMapping : IEntityTypeConfiguration<CorretorInquilinoContatos>
    {
        public void Configure(EntityTypeBuilder<CorretorInquilinoContatos> builder)
        {

            // Chave primária
            builder.HasKey(contato => contato.Id);

            // Mapeamento das propriedades
            builder
                .Property(contato => contato.DescricaoContato)
                .HasMaxLength(200)
                .IsRequired();

            builder
                .Property(contato => contato.CorretorId)
                .IsRequired();
            builder
                .Property(contato => contato.InquilinoId)
                .IsRequired();

            // Relacionamentos
            builder
                .HasOne(contato => contato.Corretor)
                .WithMany(corretor => corretor.AtendimentosInquilinos)
                .HasForeignKey(contato => contato.CorretorId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(contato => contato.Inquilino)
                .WithMany(inquilino => inquilino.AtendimentosCorretores)
                .HasForeignKey(contato => contato.InquilinoId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.ToTable("CorretorInquilinoContatos");

            builder.HasData(GetCorretorInquilinoContatos());
        }

        private IEnumerable<CorretorInquilinoContatos> GetCorretorInquilinoContatos()
        {
            return new List<CorretorInquilinoContatos>
            {
                new CorretorInquilinoContatos
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    DescricaoContato = "Renovação do contrato de locação",
                    CorretorId = Guid.Parse("00000000-0000-0000-0000-000000000009"),
                    InquilinoId = Guid.Parse("00000000-0000-0000-0000-000000000017"),
                    DataCriacao = DateTime.Now
                },
                new CorretorInquilinoContatos
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    DescricaoContato = "Discussão sobre prazo de entrega",
                    CorretorId = Guid.Parse("00000000-0000-0000-0000-000000000005"),
                    InquilinoId = Guid.Parse("00000000-0000-0000-0000-000000000013"),
                    DataCriacao = DateTime.Now
                },
                new CorretorInquilinoContatos
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000003"),
                    DescricaoContato = "Agendamento de vistoria no imóvel",
                    CorretorId = Guid.Parse("00000000-0000-0000-0000-000000000008"),
                    InquilinoId = Guid.Parse("00000000-0000-0000-0000-000000000016"),
                    DataCriacao = DateTime.Now
                },
                new CorretorInquilinoContatos
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                    DescricaoContato = "Esclarecimento de dúvidas sobre o contrato",
                    CorretorId = Guid.Parse("00000000-0000-0000-0000-000000000007"),
                    InquilinoId = Guid.Parse("00000000-0000-0000-0000-000000000015"),
                    DataCriacao = DateTime.Now
                },
                new CorretorInquilinoContatos
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000005"),
                    DescricaoContato = "Pedido de reparos no imóvel",
                    CorretorId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    InquilinoId = Guid.Parse("00000000-0000-0000-0000-000000000019"),
                    DataCriacao = DateTime.Now
                },
                new CorretorInquilinoContatos
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000006"),
                    DescricaoContato = "Negociação do valor do aluguel",
                    CorretorId = Guid.Parse("00000000-0000-0000-0000-000000000006"),
                    InquilinoId = Guid.Parse("00000000-0000-0000-0000-000000000014"),
                    DataCriacao = DateTime.Now
                },
                new CorretorInquilinoContatos
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000007"),
                    DescricaoContato = "Agendamento de visita ao imóvel",
                    CorretorId = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                    InquilinoId = Guid.Parse("00000000-0000-0000-0000-000000000012"),
                    DataCriacao = DateTime.Now
                },
                new CorretorInquilinoContatos
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000008"),
                    DescricaoContato = "Reclamação sobre problemas no imóvel",
                    CorretorId = Guid.Parse("00000000-0000-0000-0000-000000000010"),
                    InquilinoId = Guid.Parse("00000000-0000-0000-0000-000000000018"),
                    DataCriacao = DateTime.Now
                },
                new CorretorInquilinoContatos
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000009"),
                    DescricaoContato = "Confirmação de pagamento do aluguel",
                    CorretorId = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    InquilinoId = Guid.Parse("00000000-0000-0000-0000-000000000020"),
                    DataCriacao = DateTime.Now
                }
            };
        }

    }
}

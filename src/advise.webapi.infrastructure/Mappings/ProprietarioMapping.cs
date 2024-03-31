using advise.webapi.core.Models;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace advise.webapi.infrastructure.Mappings
{
    public class ProprietarioMapping : IEntityTypeConfiguration<Proprietario>
    {
        public void Configure(EntityTypeBuilder<Proprietario> builder)
        {
            // Chave primária
            builder
                .HasKey(proprietario => proprietario.Id);

            // Mapeamento das propriedades
            builder
                .Property(proprietario => proprietario.Nome)
                .HasMaxLength(100)
                .IsRequired();
            builder
                .Property(proprietario => proprietario.Telefone)
                .HasMaxLength(20)
                .IsRequired();
            builder
                .Property(proprietario => proprietario.Status)
                .IsRequired();

            // Relacionamentos
            builder
                .HasMany(proprietario => proprietario.Imoveis)
                .WithOne(imovel => imovel.Proprietario)
                .HasForeignKey(imovel => imovel.ProprietarioId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany(proprietario => proprietario.ContatosCorretores)
                .WithOne(contato => contato.Proprietario)
                .HasForeignKey(contato => contato.ProprietarioId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.ToTable("Proprietarios");

            builder.HasData(GetData());
        }

        private IEnumerable<Proprietario> GetData()
        {
            return new List<Proprietario>
        {
            new Proprietario
            {
                Id = Guid.Parse("00000000-0000-0000-0000-000000000021"),
                Nome = "José da Silva",
                Telefone = "111111111",
                Status = true,
                DataCriacao = DateTime.Now
            },
            new Proprietario
            {
                Id = Guid.Parse("00000000-0000-0000-0000-000000000022"),
                Nome = "Ana Oliveira",
                Telefone = "222222222",
                Status = true,
                DataCriacao = DateTime.Now
            },
            new Proprietario
            {
                Id = Guid.Parse("00000000-0000-0000-0000-000000000023"),
                Nome = "Luiz Pereira",
                Telefone = "333333333",
                Status = true,
                DataCriacao = DateTime.Now
            },
            new Proprietario
            {
                Id = Guid.Parse("00000000-0000-0000-0000-000000000024"),
                Nome = "Mariana Santos",
                Telefone = "444444444",
                Status = true,
                DataCriacao = DateTime.Now
            },
            new Proprietario
            {
                Id = Guid.Parse("00000000-0000-0000-0000-000000000025"),
                Nome = "Pedro Oliveira",
                Telefone = "555555555",
                Status = true,
                DataCriacao = DateTime.Now
            },
            new Proprietario
            {
                Id = Guid.Parse("00000000-0000-0000-0000-000000000026"),
                Nome = "Carla Pereira",
                Telefone = "666666666",
                Status = true,
                DataCriacao = DateTime.Now
            },
            new Proprietario
            {
                Id = Guid.Parse("00000000-0000-0000-0000-000000000027"),
                Nome = "Rafaela Lima",
                Telefone = "777777777",
                Status = true,
                DataCriacao = DateTime.Now
            },
            new Proprietario
            {
                Id = Guid.Parse("00000000-0000-0000-0000-000000000028"),
                Nome = "Gustavo Costa",
                Telefone = "888888888",
                Status = true,
                DataCriacao = DateTime.Now
            },
            new Proprietario
            {
                Id = Guid.Parse("00000000-0000-0000-0000-000000000029"),
                Nome = "Fernanda Souza",
                Telefone = "999999999",
                Status = true,
                DataCriacao = DateTime.Now
            },
            new Proprietario
            {
                Id = Guid.Parse("00000000-0000-0000-0000-000000000030"),
                Nome = "Lucas Martins",
                Telefone = "000000000",
                Status = true,
                DataCriacao = DateTime.Now
            }
        };
        }
    }
}

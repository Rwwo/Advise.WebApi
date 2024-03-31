using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using advise.webapi.core.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace advise.webapi.infrastructure.Mappings
{
    public class CorretorMapping : IEntityTypeConfiguration<Corretor>
    {
        public void Configure(EntityTypeBuilder<Corretor> builder)
        {

            // Chave primária
            builder
                .HasKey(corretor => corretor.Id);

            // Mapeamento das propriedades
            builder
                .Property(corretor => corretor.Nome)
                .HasMaxLength(100)
                .IsRequired();
            builder
                .Property(corretor => corretor.Telefone)
                .HasMaxLength(20)
                .IsRequired();
            builder
                .Property(corretor => corretor.Status)
                .IsRequired();

            builder.ToTable("Corretores");

            builder.HasData(getData());
        }

        private List<Corretor> getData()
        {
            return new List<Corretor>
        {
            new Corretor
            {
                Id = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                Nome = "João Silva",
                Telefone = "123456789",
                Status = true,
                DataCriacao = DateTime.Now
            },
            new Corretor
            {
                Id = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                Nome = "Maria Souza",
                Telefone = "987654321",
                Status = true,
                DataCriacao = DateTime.Now
            },
            new Corretor
            {
                Id = Guid.Parse("00000000-0000-0000-0000-000000000003"),
                Nome = "Pedro Santos",
                Telefone = "555555555",
                Status = true,
                DataCriacao = DateTime.Now
            },
            new Corretor
            {
                Id = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                Nome = "Ana Oliveira",
                Telefone = "999999999",
                Status = true,
                DataCriacao = DateTime.Now
            },
            new Corretor
            {
                Id = Guid.Parse("00000000-0000-0000-0000-000000000005"),
                Nome = "Carlos Fernandes",
                Telefone = "777777777",
                Status = true,
                DataCriacao = DateTime.Now
            },
            new Corretor
            {
                Id = Guid.Parse("00000000-0000-0000-0000-000000000006"),
                Nome = "Mariana Lima",
                Telefone = "444444444",
                Status = true,
                DataCriacao = DateTime.Now
            },
            new Corretor
            {
                Id = Guid.Parse("00000000-0000-0000-0000-000000000007"),
                Nome = "Rafaela Almeida",
                Telefone = "888888888",
                Status = true,
                DataCriacao = DateTime.Now
            },
            new Corretor
            {
                Id = Guid.Parse("00000000-0000-0000-0000-000000000008"),
                Nome = "Lucas Costa",
                Telefone = "666666666",
                Status = true,
                DataCriacao = DateTime.Now
            },
            new Corretor
            {
                Id = Guid.Parse("00000000-0000-0000-0000-000000000009"),
                Nome = "Fernanda Carvalho",
                Telefone = "333333333",
                Status = true,
                DataCriacao = DateTime.Now
            },
            new Corretor
            {
                Id = Guid.Parse("00000000-0000-0000-0000-000000000010"),
                Nome = "Gabriel Martins",
                Telefone = "111111111",
                Status = true,
                DataCriacao = DateTime.Now
            }
        };
        }
    }
}

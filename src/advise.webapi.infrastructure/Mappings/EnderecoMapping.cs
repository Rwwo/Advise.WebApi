using advise.webapi.core.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace advise.webapi.infrastructure.Mappings
{
    public class EnderecoMapping : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(c => c.Logradouro)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(c => c.Numero)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.Property(c => c.Cep)
                .IsRequired()
                .HasColumnType("varchar(8)");

            builder.Property(c => c.Complemento)
                .HasColumnType("varchar(250)");

            builder.Property(c => c.Bairro)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(c => c.Cidade)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(c => c.Estado)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.ToTable("Enderecos");

            builder.HasData(GetEnderecos());
        }

        private IEnumerable<Endereco> GetEnderecos()
        {
            return new List<Endereco>
            {
                new Endereco
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    Logradouro = "Av. Paulista",
                    Numero = "1000",
                    Bairro = "Bela Vista",
                    Cidade = "São Paulo",
                    Estado = "SP",
                    Cep = "01310100",
                    ImovelId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    DataCriacao = DateTime.Now
                },
                new Endereco
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    Logradouro = "Rua Oscar Freire",
                    Numero = "500",
                    Bairro = "Jardins",
                    Cidade = "São Paulo",
                    Estado = "SP",
                    Cep = "01426000",
                    ImovelId = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    DataCriacao = DateTime.Now
                },
                new Endereco
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000003"),
                    Logradouro = "Av. Atlântica",
                    Numero = "1500",
                    Bairro = "Copacabana",
                    Cidade = "Rio de Janeiro",
                    Estado = "RJ",
                    Cep = "22021001",
                    ImovelId = Guid.Parse("00000000-0000-0000-0000-000000000003"),
                    DataCriacao = DateTime.Now
                },
                new Endereco
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                    Logradouro = "Rua Augusta",
                    Numero = "800",
                    Bairro = "Consolação",
                    Cidade = "São Paulo",
                    Estado = "SP",
                    Cep = "01304001",
                    ImovelId = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                    DataCriacao = DateTime.Now
                },
                new Endereco
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000005"),
                    Logradouro = "Rua da Consolação",
                    Numero = "200",
                    Bairro = "Consolação",
                    Cidade = "São Paulo",
                    Estado = "SP",
                    Cep = "01301000",
                    ImovelId = Guid.Parse("00000000-0000-0000-0000-000000000005"),
                    DataCriacao = DateTime.Now
                },
                new Endereco
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000006"),
                    Logradouro = "Av. Brasil",
                    Numero = "300",
                    Bairro = "Jardim América",
                    Cidade = "São Paulo",
                    Estado = "SP",
                    Cep = "01430000",
                    ImovelId = Guid.Parse("00000000-0000-0000-0000-000000000006"),
                    DataCriacao = DateTime.Now
                },
                new Endereco
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000007"),
                    Logradouro = "Av. Presidente Vargas",
                    Numero = "100",
                    Bairro = "Centro",
                    Cidade = "Rio de Janeiro",
                    Estado = "RJ",
                    Cep = "20071000",
                    ImovelId = Guid.Parse("00000000-0000-0000-0000-000000000007"),
                    DataCriacao = DateTime.Now
                },
                new Endereco
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000008"),
                    Logradouro = "Rua das Flores",
                    Numero = "700",
                    Bairro = "Jardim das Flores",
                    Cidade = "Belo Horizonte",
                    Estado = "MG",
                    Cep = "30123456",
                    ImovelId = Guid.Parse("00000000-0000-0000-0000-000000000008"),
                    DataCriacao = DateTime.Now
                },
                new Endereco
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000009"),
                    Logradouro = "Av. Beira Mar",
                    Numero = "2000",
                    Bairro = "Praia de Iracema",
                    Cidade = "Fortaleza",
                    Estado = "CE",
                    Cep = "60060000",
                    ImovelId = Guid.Parse("00000000-0000-0000-0000-000000000009"),
                    DataCriacao = DateTime.Now
                },
                new Endereco
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000010"),
                    Logradouro = "Rua Padre Chagas",
                    Numero = "900",
                    Bairro = "Moinhos de Vento",
                    Cidade = "Porto Alegre",
                    Estado = "RS",
                    Cep = "90570000",
                    ImovelId = Guid.Parse("00000000-0000-0000-0000-000000000010"),
                    DataCriacao = DateTime.Now
                }
            };
        }
    }
}

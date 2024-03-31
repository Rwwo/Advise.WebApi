using advise.webapi.core.Models;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace advise.webapi.infrastructure.Context
{
    public class ApiContext : IdentityDbContext
    {

        public ApiContext(DbContextOptions<ApiContext> options)
            : base(options)
        {
            
        }

        public DbSet<Corretor> Corretores { get; set; }
        public DbSet<CorretorInquilinoContatos> CorretorInquilinoContatos { get; set; }
        public DbSet<CorretorProprietarioContatos> CorretorProprietarioContatos { get; set; }
        public DbSet<Imovel> Imoveis { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Inquilino> Inquilinos { get; set; }
        public DbSet<InquilinoImovelLocacao> InquilinoImovelLocacoes { get; set; }
        public DbSet<Proprietario> Proprietarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            foreach (var property in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetProperties()
                    .Where(p => p.ClrType == typeof(string))))
                property.SetColumnType("varchar(100)");

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApiContext).Assembly);

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys())) relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;

            base.OnModelCreating(modelBuilder);
        }

        private const string CONST_DATA = "DataCriacao";
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty(CONST_DATA) != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property(CONST_DATA).CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property(CONST_DATA).IsModified = false;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }

    }


}

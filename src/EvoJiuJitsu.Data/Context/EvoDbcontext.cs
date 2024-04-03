using EvoJiuJitsu.Business.Models;
using Microsoft.EntityFrameworkCore;

namespace EvoJiuJitsu.Data.Context
{
    public class EvoDbcontext : DbContext
    {
        public EvoDbcontext(DbContextOptions<EvoDbcontext> options) : base(options) {}

     
        public DbSet<Atleta> Atletas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(EvoDbcontext).Assembly);

            foreach(var relationship in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetForeignKeys())) relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;

            foreach (var propety in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetProperties()
                .Where(p => p.ClrType == typeof(string))))
                propety.SetColumnType("Varchar(100");

            base.OnModelCreating(modelBuilder);
                
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro")  != null))
            {
                if(entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }
    }
}

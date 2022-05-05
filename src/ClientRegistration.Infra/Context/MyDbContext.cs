using ClientRegistration.Domain;
using Microsoft.EntityFrameworkCore;

namespace ClientRegistration.Infra.Context
{
    public class MyDbContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Address> Addresses { get; set; }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.LogTo(Console.WriteLine);

#if DEBUG
            optionsBuilder.EnableDetailedErrors();
#endif

            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {            
            foreach (var property in builder.Model.GetEntityTypes()
                .SelectMany(e => e.GetProperties()
                                    .Where(p => p.ClrType == typeof(string) && p.GetMaxLength() == null && p.GetColumnType() == null)))
            {
                property.SetMaxLength(250);
                property.SetIsUnicode(false);
            }

            //Convert all table names to use the class name
            foreach (var entityType in builder.Model.GetEntityTypes())
            {
                // Skip shadow types
                if (entityType.ClrType == null)
                    continue;

                entityType.SetTableName(entityType.ClrType.Name);
            }

            base.OnModelCreating(builder);

            builder.ApplyConfigurationsFromAssembly(typeof(MyDbContext).Assembly);
        }
    }
}
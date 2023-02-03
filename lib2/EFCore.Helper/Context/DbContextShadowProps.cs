using Microsoft.EntityFrameworkCore;

namespace EFCore.Helper;

public abstract class DbContextShadowProps
    : DbContextPolicy
{
    public DbContextShadowProps()
        : base()
    {
        
    }

    public DbContextShadowProps(DbContextOptions<DbContextShadowProps> options)
        : base(options)
    {
    }

    protected DbContextShadowProps(DbContextOptions options)
        : base(options)
    {
    }

    private const string CreateDateName = "CreatedDate";
    private const string UpdateDateName = "UpdatedDate";

    protected override void SetShadowProps(ModelBuilder modelBuilder)
    {
        var allEntities = modelBuilder.Model.GetEntityTypes();

        foreach (var entity in allEntities)
        {
            entity.AddProperty(CreateDateName, typeof(DateTime));
            entity.AddProperty(UpdateDateName, typeof(DateTime));
        }
    }

    public override int SaveChanges()
    {
        SetModDatesShadowProps();
        return base.SaveChanges();
    }

    private void SetModDatesShadowProps()
    {
        var entries = ChangeTracker
            .Entries()
            .Where(e =>
                    e.State == EntityState.Added
                    || e.State == EntityState.Modified);

        foreach (var entityEntry in entries)
        {
            entityEntry.Property(UpdateDateName).CurrentValue = DateTime.Now;

            if (entityEntry.State == EntityState.Added)
            {
                entityEntry.Property(CreateDateName).CurrentValue = DateTime.Now;
            }
        }
    }
}
using Microsoft.EntityFrameworkCore;

namespace EFCore.Helper;

public abstract class DbContextTemplate
    : DbContext
{
    public DbContextTemplate()
    {
        
    }

    public DbContextTemplate(DbContextOptions<DbContextTemplate> options)
        : base(options)
    {
    }

    protected DbContextTemplate(DbContextOptions options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
        SetConfig(builder);
    }

    protected virtual void SetConfig(DbContextOptionsBuilder builder){}

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        SetPolicy(builder);
        SetShadowProps(builder);
        SeedData(builder);
    }

    protected virtual void SetPolicy(ModelBuilder builder){}

    protected virtual void SetShadowProps(ModelBuilder builder){}

    protected virtual void SeedData(ModelBuilder builder){}
}
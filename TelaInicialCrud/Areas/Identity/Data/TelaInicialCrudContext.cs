using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TelaInicialCrud.Areas.Identity.Data;
using TelaInicialCrud.Models;

namespace TelaInicialCrud.Areas.Identity.Data;

public class TelaInicialCrudContext : IdentityDbContext<Usuario>
{

    public TelaInicialCrudContext(DbContextOptions<TelaInicialCrudContext> options)
        : base(options)

    {
    }

    public DbSet<Projeto> Projeto { get; set; }



    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ApplyConfiguration(new ConfigUser());
    }
}


public class ConfigUser : IEntityTypeConfiguration<Usuario>
{
    public void Configure(EntityTypeBuilder<Usuario> builder)
    {
        builder.Property(x => x.Nome).HasMaxLength(150);
        builder.Property(x => x.Sobrenome).HasMaxLength(150);
    }
}

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PR3;

public partial class ApplicationContext : DbContext
{
    public ApplicationContext()
    {
    }

    public ApplicationContext(DbContextOptions<ApplicationContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TypeOfPartner> TypeOfPartners { get; set; }

    public virtual DbSet<TypeOfProduct> TypeOfProducts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=Partners1;Username=postgres;Password=1111");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<TypeOfPartner>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("TypeOfPartners_pkey");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.TypeOfPartner1)
                .HasMaxLength(15)
                .HasColumnName("TypeOfPartner");
        });

        modelBuilder.Entity<TypeOfProduct>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("TypeOfProducts_pkey");

            entity.Property(e => e.TypeOfProduct1)
                .HasMaxLength(20)
                .HasColumnName("TypeOfProduct");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

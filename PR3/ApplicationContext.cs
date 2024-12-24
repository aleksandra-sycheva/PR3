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

    public virtual DbSet<PartnersProduct> PartnersProducts { get; set; }

    public virtual DbSet<Pertner> Pertners { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<TypeOfPartner> TypeOfPartners { get; set; }

    public virtual DbSet<TypeOfProduct> TypeOfProducts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=Partners1;Username=postgres;Password=1111");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PartnersProduct>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Partners_Products_pkey");

            entity.ToTable("Partners_Products");

            entity.HasOne(d => d.IdPartnerNavigation).WithMany(p => p.PartnersProducts)
                .HasForeignKey(d => d.IdPartner)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Partners_Products_IdPartner_fkey");

            entity.HasOne(d => d.IdProductNavigation).WithMany(p => p.PartnersProducts)
                .HasForeignKey(d => d.IdProduct)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Partners_Products_IdProduct_fkey");
        });

        modelBuilder.Entity<Pertner>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Pertners_pkey");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Email).HasMaxLength(30);
            entity.Property(e => e.FiooftheDirector)
                .HasMaxLength(100)
                .HasColumnName("FIOOftheDirector");
            entity.Property(e => e.IdTypeOfPerther).HasColumnName("idTypeOfPerther");
            entity.Property(e => e.Inn)
                .HasMaxLength(12)
                .HasColumnName("INN");
            entity.Property(e => e.LegalAdress).HasMaxLength(100);
            entity.Property(e => e.Name).HasMaxLength(30);
            entity.Property(e => e.Phone).HasMaxLength(15);

            entity.HasOne(d => d.IdTypeOfPertherNavigation).WithMany(p => p.Pertners)
                .HasForeignKey(d => d.IdTypeOfPerther)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Pertners_idTypeOfPerther_fkey");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Products_pkey");

            entity.Property(e => e.Article).HasMaxLength(10);
            entity.Property(e => e.MinimumCost).HasColumnType("money");
            entity.Property(e => e.Name).HasMaxLength(70);

            entity.HasOne(d => d.IdTypeOfProductNavigation).WithMany(p => p.Products)
                .HasForeignKey(d => d.IdTypeOfProduct)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Products_IdTypeOfProduct_fkey");
        });

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

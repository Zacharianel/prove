using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DBPasticceria.Model
{
    public partial class PASTICCERIAContext : DbContext
    {
        public PASTICCERIAContext(string ist)
        {
            Istanza = ist;
        }

        public PASTICCERIAContext(DbContextOptions<PASTICCERIAContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Dolci> Dolci { get; set; }
        public virtual DbSet<Ingredienti> Ingredienti { get; set; }
        public virtual DbSet<Ricette> Ricette { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Vetrina> Vetrina { get; set; }
        public static string Istanza { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer(String.Format("Server={0};Database=PASTICCERIA;Trusted_Connection=True;", Istanza));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dolci>(entity =>
            {
                entity.HasKey(e => e.CodD);

                entity.ToTable("DOLCI");

                entity.Property(e => e.CodD).HasColumnName("cod_d");

                entity.Property(e => e.Costo).HasColumnName("costo");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("nome")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Ingredienti>(entity =>
            {
                entity.HasKey(e => e.CodI);

                entity.ToTable("INGREDIENTI");

                entity.Property(e => e.CodI).HasColumnName("cod_i");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("nome")
                    .HasMaxLength(50);

                entity.Property(e => e.Um)
                    .IsRequired()
                    .HasColumnName("um")
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<Ricette>(entity =>
            {
                entity.HasKey(e => e.CodR);

                entity.ToTable("RICETTE");

                entity.Property(e => e.CodR).HasColumnName("cod_r");

                entity.Property(e => e.CodD).HasColumnName("cod_d");

                entity.Property(e => e.CodI).HasColumnName("cod_i");

                entity.Property(e => e.QtaIngredienti).HasColumnName("qta_ingredienti");

                entity.HasOne(d => d.CodDNavigation)
                    .WithMany(p => p.Ricette)
                    .HasForeignKey(d => d.CodD)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RICETTE_DOLCI");

                entity.HasOne(d => d.CodINavigation)
                    .WithMany(p => p.Ricette)
                    .HasForeignKey(d => d.CodI)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RICETTE_INGREDIENTI");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.CodU);

                entity.ToTable("USER");

                entity.Property(e => e.CodU).HasColumnName("cod_u");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("nome")
                    .HasMaxLength(50);

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Vetrina>(entity =>
            {
                entity.HasKey(e => e.CodV);

                entity.ToTable("VETRINA");

                entity.Property(e => e.CodV).HasColumnName("cod_v");

                entity.Property(e => e.CodD).HasColumnName("cod_d");

                entity.Property(e => e.Data)
                    .HasColumnName("data")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.CodDNavigation)
                    .WithMany(p => p.Vetrina)
                    .HasForeignKey(d => d.CodD)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VETRINA_DOLCI");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

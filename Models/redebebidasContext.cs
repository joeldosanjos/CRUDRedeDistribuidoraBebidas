using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace RedeBebidas.Models
{
    public partial class redebebidasContext : DbContext
    {
        public redebebidasContext(DbContextOptions<redebebidasContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cliente> Clientes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.ToTable("Clientes");

                entity.Property(e => e.ClienteId).HasColumnName("ClienteId");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Nome");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Email");

                entity.Property(e => e.Cpf)
                    .IsRequired()
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Cpf");

                entity.Property(e => e.TelefoneTipo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TelefoneTipo");

                entity.Property(e => e.TelefoneNumero)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TelefoneNumero");

                entity.Property(e => e.EnderecoTipo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EnderecoTipo");

                entity.Property(e => e.Cep)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("Cep");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Estado");

                entity.Property(e => e.Cidade)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Cidade");

                entity.Property(e => e.Bairro)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Bairro");

                entity.Property(e => e.Logradouro)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("Logradouro");

                entity.Property(e => e.EnderecoNumero)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("EnderecoNumero");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

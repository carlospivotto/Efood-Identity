using System;
using System.Collections.Generic;
using System.Text;
using EFood.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EFood.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Estabelecimento> Estabelecimentos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Estabelecimento>().ToTable("Estabelecimento");
            builder.Entity<Produto>().ToTable("Produto");
            builder.Entity<Categoria>().ToTable("Categoria");

            builder.Entity<ProdutoCategoria>().ToTable("ProdutoCategoria");

            builder.Entity<ProdutoCategoria>().HasKey(pc => new { pc.ProdutoId, pc.CategoriaId });

            builder.Entity<ProdutoCategoria>()
                .HasOne(pc => pc.Produto)
                .WithMany(p => p.ProdutoCategorias)
                .HasForeignKey(pc => pc.ProdutoId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<ProdutoCategoria>()
                .HasOne(pc => pc.Categoria)
                .WithMany(c => c.ProdutoCategorias)
                .HasForeignKey(pc => pc.CategoriaId);

        }
    }
}

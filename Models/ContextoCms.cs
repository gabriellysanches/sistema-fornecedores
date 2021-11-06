using System;using System.IO;using Microsoft.EntityFrameworkCore;namespace MVC_Completo.Models{
    public class ContextoCms : DbContext
    {
        public ContextoCms(DbContextOptions<ContextoCms> options) : base(options) { }

        public ContextoCms() { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        public DbSet<Fornecedor> Fornecedores { get; set; }
    }}

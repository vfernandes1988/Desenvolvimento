﻿using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using BPNFE.Dado.EntidadesConfig;
using BPNFE.Dominio.Entidades;

namespace BPNFE.Dado.Contexto
{
    public class Contexto : DbContext
    {
        public Contexto()
            : base("BANCODADOS")
        {
        }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<FaturamentoDia> FaturamentoDias { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            modelBuilder.Configurations.Add(new ClienteConfiguracao());
            modelBuilder.Configurations.Add(new FaturamentoDiaConfiguracao());
            modelBuilder.Configurations.Add(new FornecedorConfiguracao());
            modelBuilder.Configurations.Add(new ProdutoConfiguracao());
            modelBuilder.Configurations.Add(new UsuarioConfiguracao());
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                }
            }
            return base.SaveChanges();
        }
    }
}
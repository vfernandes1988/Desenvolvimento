﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPNFE.Dominio.Entidades;

namespace BPNFE.Dado.EntidadesConfig
{
    public class ProdutoConfiguracao : EntityTypeConfiguration<Produto>
    {

        public ProdutoConfiguracao()
        {
            HasKey(p => p.ProdutoId);

            Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(250);

            Property(p => p.Valor)
                .IsRequired();

            HasRequired(p => p.Cliente)
                .WithMany()
                .HasForeignKey(p => p.ClientId);
        }
    }
}

using System.Data.Entity.ModelConfiguration;
using BPNFE.Dominio.Entidades;

namespace BPNFE.Dado.EntidadesConfig
{
    public class FornecedorConfiguracao : EntityTypeConfiguration<Fornecedor>
    {

        public FornecedorConfiguracao()
        {
            HasKey(f => f.FornecedorId);

            Property(f => f.Nome)
                .IsRequired()
                .HasMaxLength(250);

            Property(f => f.NomeFantasia)
                .IsRequired()
                .HasMaxLength(250);

            Property(f => f.Ie)
                .IsRequired()
                .HasMaxLength(250);

            Property(f => f.Cnpj)
                .IsRequired()
                .HasMaxLength(250);

            Property(f => f.Faturar)
                .IsRequired()
                .HasMaxLength(250);
        }
    }
}

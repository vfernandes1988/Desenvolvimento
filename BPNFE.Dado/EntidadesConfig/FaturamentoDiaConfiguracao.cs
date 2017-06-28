using System.Data.Entity.ModelConfiguration;
using BPNFE.Dominio.Entidades;

namespace BPNFE.Dado.EntidadesConfig
{
    public class FaturamentoDiaConfiguracao : EntityTypeConfiguration<FaturamentoDia>
    {
        public FaturamentoDiaConfiguracao()
        {
            HasKey(f => f.FaturamentoId);

            Property(f => f.Cheque)
                .IsRequired();

            Property(f => f.Credito)
                .IsRequired();

            Property(f => f.Debito)
                .IsRequired();

            Property(f => f.Dinheiro)
                .IsRequired();

            Property(f => f.Vale)
                .IsRequired();
        }
    }
}
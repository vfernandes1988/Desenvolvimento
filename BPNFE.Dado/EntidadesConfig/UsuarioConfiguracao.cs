using System.Data.Entity.ModelConfiguration;
using BPNFE.Dominio.Entidades;

namespace BPNFE.Dado.EntidadesConfig
{
    public class UsuarioConfiguracao : EntityTypeConfiguration<Usuario>
    {
        public UsuarioConfiguracao()
        {
            HasKey(u => u.UsuarioId);

            Property(u => u.Login)
                .IsRequired()
                .HasMaxLength(15);

            Property(u => u.Senha)
                .IsRequired()
                .HasMaxLength(4);

            Property(u => u.Nome)
                .IsRequired()
                .HasMaxLength(150);

            Property(u => u.Sobrenome)
                .IsRequired()
                .HasMaxLength(150);

            Property(u => u.Email)
                .IsRequired();
        }
    }
}
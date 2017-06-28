using System;

namespace BPNFE.Dominio.Entidades
{
    public class FaturamentoDia
    {
        public int FaturamentoId { get; set; }
        public decimal Cheque { get; set; }
        public decimal Credito { get; set; }
        public decimal Debito { get; set; }
        public decimal Dinheiro { get; set; }
        public decimal Vale { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataLancamento { get; set; }
    }
}
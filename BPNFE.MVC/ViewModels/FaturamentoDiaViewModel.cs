using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BPNFE.MVC.ViewModels
{
    public class FaturamentoDiaViewModel
    {
        [Key]
        public int FaturamentoId { get; set; }
        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "999999999999")]
        [Required(ErrorMessage = "Preencha um valor")]
        public decimal Cheque { get; set; }
        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "999999999999")]
        [Required(ErrorMessage = "Preencha um valor")]
        public decimal Credito { get; set; }
        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "999999999999")]
        [Required(ErrorMessage = "Preencha um valor")]
        public decimal Debito { get; set; }
        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "999999999999")]
        [Required(ErrorMessage = "Preencha um valor")]
        public decimal Dinheiro { get; set; }
        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "999999999999")]
        [Required(ErrorMessage = "Preencha um valor")]
        public decimal Vale { get; set; }
        public FaturamentoDiaViewModel()
        {
            DataCadastro = DateTime.Now;
        }
        public DateTime DataCadastro { get; set; }
        [Required(ErrorMessage = "Preencha a data")]
        public DateTime DataLancamento { get; set; }

    }
}
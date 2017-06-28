using System;

namespace BPNFE.Dominio.Entidades
{
    public class Fornecedor
    {
        public int FornecedorId { get; set; }
        public string Nome { get; set; }
        public string NomeFantasia { get; set; }
        public string Ie { get; set; }
        public string Cnpj { get; set; }
        public string Endereco { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string NomeContato { get; set; }
        public string TelefoneContato { get; set; }
        public string Informacao { get; set; }
        public string Faturar { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
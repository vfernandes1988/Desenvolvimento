﻿namespace BPNFE.Dominio.Entidades
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public bool Disponivel { get; set; }
        public int ClientId { get; set; }
        public virtual Cliente Cliente { get; set; }
    }
}

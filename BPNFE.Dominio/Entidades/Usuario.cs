using System;
using System.Collections;
using System.Collections.Generic;

namespace BPNFE.Dominio.Entidades
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
        public string TipoUsuario { get; set; }
        //public virtual IEnumerable<Produto> Produtos { get; set; }
        public bool Administrador(Usuario usuario)
        {
            return usuario.Ativo && usuario.TipoUsuario == "Administrador";
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPNFE.Dominio.Entidades;
using BPNFE.Dominio.Interfaces.Repositorios;
using BPNFE.Dominio.Interfaces.Servicos;

namespace BPNFE.Dominio.Servicos
{
    public class ProdutoServico : BaseServico<Produto>, IProdutoServico
    {
        private readonly IProdutoRepositorio _produtoRepositorio;

        public ProdutoServico(IProdutoRepositorio produtoRepositorio)
            : base(produtoRepositorio)
        {
            _produtoRepositorio = produtoRepositorio;
        }

        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return _produtoRepositorio.BuscarPorNome(nome);
        }
    }
}

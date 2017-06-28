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
    public class FornecedorServico : BaseServico<Fornecedor>, IFornecedorServico
    {
        private readonly IFornecedorRepositorio _fornecedorRepositorio;

        public FornecedorServico(IFornecedorRepositorio fornecedorRepositorio)
            : base(fornecedorRepositorio)
        {
            _fornecedorRepositorio = fornecedorRepositorio;
        }

        public IEnumerable<Fornecedor> BuscarPorNome(string nome)
        {
            return _fornecedorRepositorio.BuscarPorNome(nome);
        }
    }
}

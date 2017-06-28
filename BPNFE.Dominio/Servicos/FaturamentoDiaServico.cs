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
    public class FaturamentoDiaServico : BaseServico<FaturamentoDia>, IFaturamentoDiaServico
    {
        private readonly IFaturamentoDiaRepositorio _faturamentoDiaRepositorio;

        public FaturamentoDiaServico(IFaturamentoDiaRepositorio faturamentoDiaRepositorio)
            : base(faturamentoDiaRepositorio)
        {
            _faturamentoDiaRepositorio = faturamentoDiaRepositorio;
        }

        public IEnumerable<FaturamentoDia> BuscarPorNome(DateTime dataLancamento)
        {
            return _faturamentoDiaRepositorio.BuscarPorNome(dataLancamento);
        }
    }
}

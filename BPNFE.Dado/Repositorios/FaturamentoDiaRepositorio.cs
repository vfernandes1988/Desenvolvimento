using System;
using System.Collections.Generic;
using System.Linq;
using BPNFE.Dominio.Entidades;
using BPNFE.Dominio.Interfaces.Repositorios;

namespace BPNFE.Dado.Repositorios
{
    public class FaturamentoDiaRepositorio : BaseRepositorio<FaturamentoDia>, IFaturamentoDiaRepositorio
    {

        public IEnumerable<FaturamentoDia> BuscarPorNome(DateTime dataLancamento)
        {
            return Db.FaturamentoDias.Where(p => p.DataLancamento == dataLancamento);
        }
    }
}
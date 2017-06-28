using System;
using System.Collections.Generic;
using BPNFE.Dominio.Entidades;

namespace BPNFE.Dominio.Interfaces.Repositorios
{
    public interface IFaturamentoDiaRepositorio : IBaseRepositorio<FaturamentoDia>
    {
        IEnumerable<FaturamentoDia> BuscarPorNome(DateTime dataLancamento);
    }
}
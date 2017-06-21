using System.Collections.Generic;
using BPNFE.Dominio.Entidades;

namespace BPNFE.Dominio.Interfaces.Repositorios
{
    public interface IProdutoBaseRepositorio : IBaseRepositorio<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}

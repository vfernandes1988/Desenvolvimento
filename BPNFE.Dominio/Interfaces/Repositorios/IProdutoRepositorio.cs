using System.Collections.Generic;
using BPNFE.Dominio.Entidades;

namespace BPNFE.Dominio.Interfaces.Repositorios
{
    public interface IProdutoRepositorio : IBaseRepositorio<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}
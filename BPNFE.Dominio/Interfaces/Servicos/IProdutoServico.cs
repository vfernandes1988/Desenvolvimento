using System.Collections.Generic;
using BPNFE.Dominio.Entidades;

namespace BPNFE.Dominio.Interfaces.Servicos
{
    public interface IProdutoServico : IBaseServico<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}

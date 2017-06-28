using System.Collections.Generic;
using BPNFE.Dominio.Entidades;

namespace BPNFE.Dominio.Interfaces.Servicos
{
    public interface IFornecedorServico : IBaseServico<Fornecedor>
    {
        IEnumerable<Fornecedor> BuscarPorNome(string nome);
    }
}

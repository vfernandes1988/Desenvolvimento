using System.Collections.Generic;
using BPNFE.Dominio.Entidades;

namespace BPNFE.Dominio.Interfaces.Servicos
{
    public interface IClienteServico : IBaseServico<Cliente>
    {
        IEnumerable<Cliente> ObterClientesEspeciais(IEnumerable<Cliente> clientes);
    }
}

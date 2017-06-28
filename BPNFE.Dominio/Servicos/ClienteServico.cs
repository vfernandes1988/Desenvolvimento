using System.Collections.Generic;
using System.Linq;
using BPNFE.Dominio.Entidades;
using BPNFE.Dominio.Interfaces.Repositorios;
using BPNFE.Dominio.Interfaces.Servicos;

namespace BPNFE.Dominio.Servicos
{
    public class ClienteServico : BaseServico<Cliente>, IClienteServico
    {
        private readonly IClienteRepositorio _clienteRepositorio;

        public ClienteServico(IClienteRepositorio clienteRepositorio)
            : base(clienteRepositorio)
        {
            _clienteRepositorio = clienteRepositorio;
        }

        public IEnumerable<Cliente> ObterClientesEspeciais(IEnumerable<Cliente> clientes)
        {
            return clientes.Where(c => c.ClienteEspecial(c));
        }
    }
}

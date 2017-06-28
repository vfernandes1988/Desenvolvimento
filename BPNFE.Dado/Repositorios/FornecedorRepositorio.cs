using System.Collections.Generic;
using System.Linq;
using BPNFE.Dominio.Entidades;
using BPNFE.Dominio.Interfaces.Repositorios;

namespace BPNFE.Dado.Repositorios
{
    public class FornecedorRepositorio : BaseRepositorio<Fornecedor>, IFornecedorRepositorio
    {
        public IEnumerable<Fornecedor> BuscarPorNome(string nome)
        {
            return Db.Fornecedores.Where(f => f.Nome == nome);
        }
    }
}

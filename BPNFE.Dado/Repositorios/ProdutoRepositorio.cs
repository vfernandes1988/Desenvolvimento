using System.Collections.Generic;
using System.Linq;
using BPNFE.Dominio.Entidades;
using BPNFE.Dominio.Interfaces.Repositorios;

namespace BPNFE.Dado.Repositorios
{
    public class ProdutoBaseRepositorio : BaseRepositorio<Produto>, IProdutoRepositorio
    {
        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return Db.Produtos.Where(p => p.Nome == nome);
        }
    }
}

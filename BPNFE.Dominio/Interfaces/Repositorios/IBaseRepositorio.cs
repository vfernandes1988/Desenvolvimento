using System.Collections.Generic;

namespace BPNFE.Dominio.Interfaces.Repositorios
{
    public interface IBaseRepositorio<TEntity> where TEntity : class
    {
        void Inserir(TEntity obj);
        TEntity BuscarId(int id);
        IEnumerable<TEntity> BuscarTodos();
        void Atualizar(TEntity obj);
        void Remover(TEntity obj);
        void Dispose();
    }
}

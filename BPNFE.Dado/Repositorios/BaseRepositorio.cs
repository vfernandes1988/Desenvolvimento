using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using BPNFE.Dominio.Interfaces.Repositorios;

namespace BPNFE.Dado.Repositorios
{
    public class BaseRepositorio<TEntity> : IDisposable, IRepositorioBase<TEntity> where TEntity : class
    {
        protected Contexto.Contexto Db = new Contexto.Contexto();

        public void Inserir(TEntity obj)
        {
            Db.Set<TEntity>().Add(obj);
            Db.SaveChanges();
        }

        public TEntity BuscarPorId(int id)
        {
            return Db.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> BuscarTodos()
        {
            return Db.Set<TEntity>().ToList();
        }

        public void Atualizar(TEntity obj)
        {
            Db.Entry(obj).State = EntityState.Modified;
            Db.SaveChanges();
        }

        public void Remover(TEntity obj)
        {
            Db.Set<TEntity>().Remove(obj);
            Db.SaveChanges();
        }

        void IRepositorioBase<TEntity>.Dispose()
        {
            throw new NotImplementedException();
        }

        void IDisposable.Dispose()
        {
            throw new NotImplementedException();
        }
    }
}

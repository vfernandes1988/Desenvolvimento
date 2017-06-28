using System;
using System.Collections.Generic;
using BPNFE.Dominio.Interfaces.Repositorios;
using BPNFE.Dominio.Interfaces.Servicos;

namespace BPNFE.Dominio.Servicos
{
    public class BaseServico<TEntity> : IDisposable, IBaseServico<TEntity> where TEntity : class
    {
        private readonly IBaseRepositorio<TEntity> _repositorio;

        public BaseServico(IBaseRepositorio<TEntity> repositorio)
        {
            _repositorio = repositorio;
        }

        public void Atualizar(TEntity obj)
        {
            _repositorio.Atualizar(obj);
        }

        public TEntity BuscarId(int id)
        {
            return _repositorio.BuscarId(id);
        }

        public IEnumerable<TEntity> BuscarTodos()
        {
            return _repositorio.BuscarTodos();
        }

        public void Dispose()
        {
            _repositorio.Dispose();
        }

        public void Inserir(TEntity obj)
        {
            _repositorio.Inserir(obj);
        }

        public void Remover(TEntity obj)
        {
            _repositorio.Remover(obj);
        }
    }
}

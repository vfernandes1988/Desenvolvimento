﻿using System.Collections.Generic;

namespace BPNFE.Dominio.Interfaces.Servicos
{
    public interface IBaseServico<TEntity> where TEntity : class
    {
        void Add(TEntity obj);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        void Update(TEntity obj);
        void Remove(TEntity obj);
        void Dispose();
    }
}

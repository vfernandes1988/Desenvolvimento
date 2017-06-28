using System;
using System.Collections.Generic;
using BPNFE.Dominio.Entidades;

namespace BPNFE.Dominio.Interfaces.Repositorios
{
    public interface IFornecedorRepositorio : IBaseRepositorio<Fornecedor>
    {
        IEnumerable<Fornecedor> BuscarPorNome(string nome);
    }
}